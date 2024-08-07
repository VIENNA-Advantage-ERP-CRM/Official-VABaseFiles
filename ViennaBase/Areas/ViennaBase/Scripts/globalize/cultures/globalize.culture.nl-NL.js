/*
 * Globalize Culture nl-NL
 *
 * http://github.com/jquery/globalize
 *
 * Copyright Software Freedom Conservancy, Inc.
 * Dual licensed under the MIT or GPL Version 2 licenses.
 * http://jquery.org/license
 *
 * This file was generated by the Globalize Culture Generator
 * Translation: bugs found in this file need to be fixed in the generator
 */

(function( window, undefined ) {

var Globalize;

if ( typeof require !== "undefined" &&
	typeof exports !== "undefined" &&
	typeof module !== "undefined" ) {
	// Assume CommonJS
	Globalize = require( "globalize" );
} else {
	// Global variable
	Globalize = window.Globalize;
}

Globalize.addCultureInfo( "nl-NL", "default", {
	name: "nl-NL",
	englishName: "Dutch (Netherlands)",
	nativeName: "Nederlands (Nederland)",
	language: "nl",
	numberFormat: {
		",": ".",
		".": ",",
		percent: {
			",": ".",
			".": ","
		},
		currency: {
			pattern: ["$ -n","$ n"],
			",": ".",
			".": ",",
			symbol: "€"
		}
	},
	calendars: {
		standard: {
			"/": "-",
			firstDay: 1,
			days: {
				names: ["zondag","maandag","dinsdag","woensdag","donderdag","vrijdag","zaterdag"],
				namesAbbr: ["zo","ma","di","wo","do","vr","za"],
				namesShort: ["zo","ma","di","wo","do","vr","za"]
			},
			months: {
				names: ["januari","februari","maart","april","mei","juni","juli","augustus","september","oktober","november","december",""],
				namesAbbr: ["jan","feb","mrt","apr","mei","jun","jul","aug","sep","okt","nov","dec",""]
			},
			AM: null,
			PM: null,
			patterns: {
				d: "d-M-yyyy",
				D: "dddd d MMMM yyyy",
				t: "H:mm",
				T: "H:mm:ss",
				f: "dddd d MMMM yyyy H:mm",
				F: "dddd d MMMM yyyy H:mm:ss",
				M: "dd MMMM",
				Y: "MMMM yyyy"
			}
		}
	},
	messages: {

	    "Connection": "Verbinding",
    "Defaults": "Standaard",
    "Login": "Aanmelden bij Vienna",
    "File": "Bestand",
    "Exit": "Afsluiten",
    "Help": "Help",
    "About": "Info",
    "Host": "Server",
    "Database": "Database",
    "User": "Gebruikersnaam",
    "EnterUser": "Voer uw gebruikersnaam in",
    "Password": "Wachtwoord",
    "EnterPassword": "Voer uw wachtwoord in",
    "Language": "Taal",
    "SelectLanguage": "Selecteer uw taal",
    "Role": "Rol",
    "Client": "Client",
    "Organization": "Organisatie",
    "Date": "Datum",
    "Warehouse": "Magazijn",
    "Printer": "Printer",
    "Connected": "Verbonden",
    "NotConnected": "Niet verbonden",
    "DatabaseNotFound": "Database niet gevonden",
    "UserPwdError": "Foute gebruikersnaam of wachtwoord",
    "RoleNotFound": "Rol niet gevonden of incompleet",
    "Authorized": "Geautoriseerd",
    "Ok": "Ok",
    "Cancel": "Annuleren",
    "VersionConflict": "Versie Conflict:",
    "VersionInfo": "Server <> Client",
    "PleaseUpgrade": "Gelieve de nieuwe versie van de server te downloaden",

    //New Resource

    "Back": "terug",
    "SelectRole": "Selecteer Rol",
    "SelectOrg": "Selecteer Organisatie",
    "SelectClient": "Selecteer Client",
    "SelectWarehouse": "Selecteer Warehouse",
    "VerifyUserLanguage": "Controle gebruiker en Taal",
    "LoadingPreference": "Voorkeur laden",
    "Completed": "aanvullen",
    "RememberMe": "Onthoud Me",
        "FillMandatoryFields": "Vul verplichte velden in",
        "BothPwdNotMatch": "Beide wachtwoorden moeten overeenkomen.",
        "mustMatchCriteria": "Minimale lengte voor wachtwoord is 5. Wachtwoord moet minimaal 1 hoofdletter, 1 kleine letter, 1 speciaal teken (@ $!% *? &) En één cijfer bevatten. Wachtwoord moet beginnen met karakter.",
        "NotLoginUser": "Gebruiker kan niet inloggen op het systeem",
        "MaxFailedLoginAttempts": "Gebruikersaccount is vergrendeld. Het maximale aantal mislukte inlogpogingen overschrijdt de gedefinieerde limiet. Neem contact op met de beheerder.",
        "UserNotFound": "Gebruikersnaam is onjuist.",
        "RoleNotDefined": "Geen rol gedefinieerd voor deze gebruiker",
        "oldNewSamePwd": "oud wachtwoord en nieuw wachtwoord moeten verschillend zijn.",
        "NewPassword": "nieuw paswoord",
        "NewCPassword": "Bevestig nieuw wachtwoord",
        "EnterOTP": "Voer OTP in",
        "WrongOTP": "Verkeerde OTP ingevoerd",
        "ScanQRCode": "Scan de code met Google Authenticator",
        "EnterVerCode": "Voer OTP in die is gegenereerd door uw mobiele applicatie",
		"EnterVAVerCode": "Voer OTP in dat is ontvangen op uw geregistreerde mobiel",
		"SkipThisTime": "Deze keer overslaan",
		"ResendOTP": "OTP opnieuw verzenden",
		"CapsLockOn": "Caps Lock staat aan",
		"AccessNotGranted": "Er kan geen toegang worden verleend. Controleer uw inloggegevens of systeemtoegang.",
	}

});

}( this ));
