/*
 * Globalize Culture zh-CN
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

Globalize.addCultureInfo( "zh-CN", "default", {
	name: "zh-CN",
	englishName: "Chinese (Simplified, PRC)",
	nativeName: "中文(中华人民共和国)",
	language: "zh-CHS",
	numberFormat: {
		"NaN": "非数字",
		negativeInfinity: "负无穷大",
		positiveInfinity: "正无穷大",
		percent: {
			pattern: ["-n%","n%"]
		},
		currency: {
			pattern: ["$-n","$n"],
			symbol: "¥"
		}
	},
	calendars: {
		standard: {
			days: {
				names: ["星期日","星期一","星期二","星期三","星期四","星期五","星期六"],
				namesAbbr: ["周日","周一","周二","周三","周四","周五","周六"],
				namesShort: ["日","一","二","三","四","五","六"]
			},
			months: {
				names: ["一月","二月","三月","四月","五月","六月","七月","八月","九月","十月","十一月","十二月",""],
				namesAbbr: ["一月","二月","三月","四月","五月","六月","七月","八月","九月","十月","十一月","十二月",""]
			},
			AM: ["上午","上午","上午"],
			PM: ["下午","下午","下午"],
			eras: [{"name":"公元","start":null,"offset":0}],
			patterns: {
				d: "yyyy/M/d",
				D: "yyyy'年'M'月'd'日'",
				t: "H:mm",
				T: "H:mm:ss",
				f: "yyyy'年'M'月'd'日' H:mm",
				F: "yyyy'年'M'月'd'日' H:mm:ss",
				M: "M'月'd'日'",
				Y: "yyyy'年'M'月'"
			}
		}
	},
	messages: {
	    "Connection": "\u8fde\u673a",
	    "Defaults": "\u9ed8\u8ba4\u8bbe\u7f6e",
	    "Login": "Vienna \u767b\u5f55",
	    "File": "\u6587\u4ef6",
	    "Exit": "\u9000\u51fa",
	    "Help": "\u5e2e\u52a9",
	    "About": "\u5173\u4e8e",
	    "Host": "\u4e3b\u673a",
	    "Database": "\u6570\u636e\u5e93",
	    "User": "\u7528\u6237\u53f7",
	    "EnterUser": "\u8bf7\u8f93\u5165\u7528\u6237\u53f7",
	    "Password": "\u53e3\u4ee4",
	    "EnterPassword": "\u8bf7\u8f93\u5165\u53e3\u4ee4",
	    "Language": "\u8bed\u8a00",
	    "SelectLanguage": "\u9009\u62e9\u8bed\u8a00",
	    "Role": "\u89d2\u8272",
	    "Client": "\u5b9e\u4f53",
	    "Organization": "\u7EC4\u7EC7",
	    "Date": "\u65e5\u671f",
	    "Warehouse": "\u4ed3\u5e93",
	    "Printer": "\u6253\u5370\u673a",
	    "Connected": "\u5df2\u5728\u7ebf",
	    "NotConnected": "\u672a\u5728\u7ebf",
	    "DatabaseNotFound": "\u672a\u627e\u5230\u6570\u636e\u5e93",
	    "UserPwdError": "\u7528\u6237\u53f7\u53e3\u4ee4\u4e0d\u6b63\u786e",
	    "RoleNotFound": "\u6ca1\u6709\u6b64\u89d2\u8272",
	    "Authorized": "\u5df2\u6388\u6743",
	    "Ok": "\u786e\u5b9a",
	    "Cancel": "\u64a4\u6d88",
	    "VersionConflict": "\u7248\u672c\u51b2\u7a81\uff1a",
	    "VersionInfo": "\u670d\u52a1\u5668\u7aef <> \u5ba2\u6237\u7aef",
	    "PleaseUpgrade": "\u8bf7\u5347\u7ea7\u7a0b\u5e8f",
	    "GoodMorning": "Guten Morgen",
	    "GoodAfternoon": "Guten Tag",
	    "GoodEvening": "Guten Abend",

	    //New Resource

	    "Back": "\u8bf7\u5347\u7ea7\u7a0b\u5e8f",
	    "SelectRole": "\u8bf7\u5347\u7ea7\u7a0b\u5e8f",
	    "SelectOrg": "\u786e\u5b9a",
	    "SelectClient": "\u5df2\u6388\u6743",
	    "SelectWarehouse": "\u7528\u6237\u53f7\u53e3\u4ee4\u4e0d\u6b63\u786e",
	    "VerifyUserLanguage": "\u64a4\u6d88",
	    "LoadingPreference": "\u64a4\u6d88",
	    "Completed": "\u64a4\u6d88",
	    //new
	    "RememberMe": "\u64a4\u6d88",
        "FillMandatoryFields": "\u64a4\u6d88",
        "BothPwdNotMatch": "Both passwords must match.",
        "mustMatchCriteria": "Minimum length for password is 5. Password must have at least 1 upper case character, 1 lower case character, one special character(@$!%*?&) and one digit. Password must start with character.",
        "NotLoginUser": "User cannot login into system",
        "MaxFailedLoginAttempts": "User account is locked. Maximum failed login attempts exceeds the defined limit. Please contact to administrator.",
        "UserNotFound": "Username is incorrect.",
        "RoleNotDefined": "No role defined for this user",
        "oldNewSamePwd": "old password and new password must be different.",
        "NewPassword": "New Password",
        "NewCPassword": "Confirm New Password",
        "EnterOTP": "Enter OTP",
        "WrongOTP": "Wrong OTP Entered",
        "ScanQRCode": "Scan the code with Google Authenticator",
		"EnterVerCode": "Enter OTP generated by Google Authenticator",
		"EnterVAVerCode": "Enter OTP received on your registered mobile",
		"SkipThisTime": "Skip this time",
		"ResendOTP": "Resend OTP",
		"CapsLockOn": "Caps lock is on",
	}
});

}( this ));
