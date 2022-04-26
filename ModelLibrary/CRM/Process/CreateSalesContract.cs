﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VAdvantage.ProcessEngine;
using VAdvantage.Utility;
using VAdvantage.Logging;
//using ViennaAdvantage.Model;
using VAdvantage.DataBase;
using System.Data;
using VAdvantage.Model;

/* Process: Create Sales Order Contract 
 * Writer :Arpit Singh
 * Date   : 31/1/12 
 */

namespace VAdvantage.Process
{
    class CreateSalesContract : SvrProcess
    {
        int orderID;
        IDataReader dr;

        protected override void Prepare()
        {
            orderID = GetRecord_ID();
        }

        protected override String DoIt()
        {
            int C_Contract_ID = 0;
            String Sql = String.Empty;
            VAdvantage.Model.X_C_Order order = new VAdvantage.Model.X_C_Order(GetCtx(), orderID, null);
            string DocStatus = order.GetDocStatus();
            if (DocStatus != "CO")
            {
                return Msg.GetMsg(GetCtx(), "FirstCompleteOrder");
            }

            try
            {
                Sql = "Select C_OrderLine_ID from C_OrderLine where C_Order_ID=" + orderID;
                dr = DB.ExecuteReader(Sql);
                while (dr.Read())
                {
                    VAdvantage.Model.X_C_OrderLine line = new VAdvantage.Model.X_C_OrderLine(GetCtx(), Util.GetValueOfInt(dr[0]), null);
                    if (line.IsContract() && line.GetC_Contract_ID() == 0)
                    {

                        VAdvantage.Model.X_C_Contract contact = new VAdvantage.Model.X_C_Contract(GetCtx(), 0, null);
                        VAdvantage.Model.MProductPricing pp = new VAdvantage.Model.MProductPricing(GetCtx().GetAD_Client_ID(), GetCtx().GetAD_Org_ID(),
                            line.GetM_Product_ID(), order.GetC_BPartner_ID(), line.GetQtyOrdered(), true);
                        int M_PriceList_ID = Util.GetValueOfInt(order.GetM_PriceList_ID());
                        pp.SetM_PriceList_ID(M_PriceList_ID);

                        string sql = "SELECT pl.IsTaxIncluded,pl.EnforcePriceLimit,pl.C_Currency_ID,c.StdPrecision,"
                        + "plv.M_PriceList_Version_ID,plv.ValidFrom "
                        + "FROM M_PriceList pl,C_Currency c,M_PriceList_Version plv "
                        + "WHERE pl.C_Currency_ID=c.C_Currency_ID"
                        + " AND pl.M_PriceList_ID=plv.M_PriceList_ID"
                        + " AND pl.M_PriceList_ID=" + M_PriceList_ID                        //	1
                        + "ORDER BY plv.ValidFrom DESC";

                        int M_PriceList_Version_ID = 0;
                        int C_Currency_ID = 0;
                        DataSet ds = DB.ExecuteDataset(sql, null);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            C_Currency_ID = Util.GetValueOfInt(ds.Tables[0].Rows[i]["C_Currency_ID"]);
                            //	PriceList Version
                            M_PriceList_Version_ID = Util.GetValueOfInt(ds.Tables[0].Rows[i]["M_PriceList_Version_ID"]);
                        }
                        //int M_PriceList_Version_ID = GetCtx().GetContextAsInt(WindowNo, "M_PriceList_Version_ID");
                        pp.SetM_PriceList_Version_ID(M_PriceList_Version_ID);


                        contact.SetDescription(order.GetDescription());
                        contact.SetC_Order_ID(order.GetC_Order_ID());
                        contact.SetC_OrderLine_ID(line.GetC_OrderLine_ID());
                        contact.SetStartDate(line.GetStartDate());
                        contact.SetEndDate(line.GetEndDate());

                        contact.SetC_BPartner_ID(order.GetC_BPartner_ID());
                        contact.SetBill_Location_ID(order.GetBill_Location_ID());
                        contact.SetBill_User_ID(order.GetBill_User_ID());
                        contact.SetSalesRep_ID(order.GetSalesRep_ID());

                        contact.SetC_Currency_ID(line.GetC_Currency_ID());
                        contact.SetC_ConversionType_ID(order.GetC_ConversionType_ID());
                        contact.SetC_PaymentTerm_ID(order.GetC_PaymentTerm_ID());
                        contact.SetM_PriceList_ID(order.GetM_PriceList_ID());
                        contact.SetC_Frequency_ID(line.GetC_Frequency_ID());

                        contact.SetPriceList(pp.GetPriceList());
                        contact.SetPriceActual(pp.GetPriceStd());
                        contact.SetPriceEntered(pp.GetPriceStd());
                        contact.SetQtyEntered(line.GetQtyPerCycle());

                        Decimal discount = Decimal.Round(Decimal.Divide(Decimal.Multiply(Decimal.Subtract(pp.GetPriceList(), pp.GetPriceStd()), new Decimal(100)), pp.GetPriceList()), 2);
                        contact.SetDiscount(discount);

                        // invoice Count Start
                        contact.SetTotalInvoice(line.GetNoofCycle());

                        contact.SetC_Project_ID(order.GetC_Project_ID());
                        contact.SetC_UOM_ID(line.GetC_UOM_ID());
                        contact.SetM_Product_ID(line.GetM_Product_ID());
                        contact.SetC_Tax_ID(line.GetC_Tax_ID());
                        contact.SetC_Campaign_ID(order.GetC_Campaign_ID());

                        sql = "select rate from c_tax where c_tax_id = " + line.GetC_Tax_ID();
                        Decimal? rate = Util.GetNullableDecimal(DB.ExecuteScalar(sql, null, null));
                        Decimal? amt = Decimal.Multiply(pp.GetPriceStd(), (Decimal.Divide(rate.Value, 100)));
                        amt = Decimal.Round(amt.Value, 2, MidpointRounding.AwayFromZero);
                        Decimal? taxAmt = Decimal.Multiply(amt.Value, line.GetQtyPerCycle());

                        contact.SetTaxAmt(taxAmt);
                        contact.SetGrandTotal(Decimal.Add(Decimal.Multiply(line.GetQtyPerCycle(), pp.GetPriceStd()), taxAmt.Value));
                        contact.SetLineNetAmt(Decimal.Multiply(line.GetQtyPerCycle(), pp.GetPriceStd()));

                        contact.SetDocStatus("DR");
                        contact.SetRenewContract("N");
                        if (contact.Save())
                        {
                            line.SetC_Contract_ID(contact.GetC_Contract_ID());
                            if (line.Save())
                            {

                            }
                        }
                        C_Contract_ID = contact.GetC_Contract_ID();
                    }
                }
                dr.Close();

                order.SetCreateServiceContract("Y");
                if (!order.Save())
                {
                    ValueNamePair pp = VLogger.RetrieveError();
                    String error = String.Empty;
                    if (pp != null)
                    {
                        error = pp.GetValue();
                        if (String.IsNullOrEmpty(error))
                        {
                            error = pp.GetName();
                        }
                    }
                    log.Log(Level.SEVERE, "Could Not Save Order. " + error);
                }
            }
            catch (Exception ex)
            {
                log.Log(Level.SEVERE, "CreateSalesContract" + Sql, ex);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                    dr = null;
                }
            }

            return Msg.GetMsg(GetCtx(), "ServiceContractGenerationDone");
        }
    }
}
