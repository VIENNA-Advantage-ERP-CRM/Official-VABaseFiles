# Onfinity Base Files

**The base and core libraries of Onfinity ERP and CRM (formerly VIENNA Advantage), in C#/.NET.** Everything else is built on top: the [framework](https://github.com/VIENNA-Advantage-ERP-CRM/Official-VAFramework) with the Application Dictionary, then the [ERP and CRM application](https://github.com/VIENNA-Advantage-ERP-CRM/Official-VAStandard-ERP-CRM). Build this repository first.

Onfinity was named VIENNA Advantage until 2024; the code, the product and the company are the same.

| Project | Contents |
|---|---|
| `CoreLibrary` | Database access for PostgreSQL and Oracle, SQL execution, the data port, logging, printing, resources. |
| `BaseLibrary` | The engines the framework runs on: the model engine, model validation, processes, login and sessions, audit, alerts, the Application Dictionary base classes. |
| `XModel` | The generated `X_` model classes, one per table of the Application Dictionary and the business model, with typed getters and setters for every column. |
| `VAPrintLib` | The print engine: print formats, documents and reports laid out in the system. |
| `ViennaBase` | The base web project (areas, filters, views) the application web project starts from. |

## Building

Open `ViennaAdvantageWeb.sln` in Visual Studio 2019 or later (.NET Framework) and build. The compiled libraries go into the `DLL` folder of the application's web project; the full sequence is in the ERP repository's [BUILD.md](https://github.com/VIENNA-Advantage-ERP-CRM/Official-VAStandard-ERP-CRM/blob/master/BUILD.md). The library versions must match the *Vienna Advantage Base Files* module version in the database you run against (Module Management, System Administration role).

| | |
|---|---|
| Website | https://onfinity.io |
| Ready-to-run packages | https://sourceforge.net/projects/erp-crm-advant/files/ |
| Development guide | https://viennaadvantage.atlassian.net/wiki/spaces/VA/pages/9207809/Development+Guide |

## Licence

Eclipse Public Licence. See https://onfinity.io/open-source-erp.php.
