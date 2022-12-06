/* ****** 1159 - On-leave PAGE 50 Rev 0 ****** */

/* REV. 0    ORIGINAL */


/* ****** CRLF3 ****** */

string CRLF3 ;
CRLF3 = "\n";


/* ****** Inputs.HYBRID.Value ****** */
/* ****** 1359 - On-leave Inputs.HYBRID.Value ****** */

if (Inputs.HYBRID.Value == "16/33/41") {
    Inputs.Z1_PART.Value = "1359-441-1A-1633";
    Inputs.Z2_PART.Value = "1359-441-2A-1633";
    Inputs.Z3_PART.Value = "1359-441-0A-3341";
}

if (Inputs.HYBRID.Value == "17/32/42") {
    Inputs.Z1_PART.Value = "1359-441-1A-1732";
    Inputs.Z2_PART.Value = "1359-441-2A-1732";
    Inputs.Z3_PART.Value = "1359-441-0A-3242";
}

if (Inputs.HYBRID.Value == "18/31/43") {
    Inputs.Z1_PART.Value = "1359-441-1A-1831";
    Inputs.Z2_PART.Value = "1359-441-2A-1831";
    Inputs.Z3_PART.Value = "1359-441-0A-3143";
}

if (Inputs.HYBRID.Value == "19/30/44") {
    Inputs.Z1_PART.Value = "1359-441-1A-1930";
    Inputs.Z2_PART.Value = "1359-441-2A-1930";
    Inputs.Z3_PART.Value = "1359-441-0A-3044";
}

if (Inputs.HYBRID.Value == "20/29/45") {
    Inputs.Z1_PART.Value = "1359-441-1A-2029";
    Inputs.Z2_PART.Value = "1359-441-2A-2029";
    Inputs.Z3_PART.Value = "1359-441-0A-2945";
}

if (Inputs.HYBRID.Value == "21/28/46") {
    Inputs.Z1_PART.Value = "1359-441-1A-2128";
    Inputs.Z2_PART.Value = "1359-441-2A-2128";
    Inputs.Z3_PART.Value = "1359-441-0A-2846";
}

if (Inputs.HYBRID.Value == "22/27/47") {
    Inputs.Z1_PART.Value = "1359-441-1A-2227";
    Inputs.Z2_PART.Value = "1359-441-2A-2227";
    Inputs.Z3_PART.Value = "1359-441-0A-2747";
}

if (Inputs.HYBRID.Value == "23/26/48") {
    Inputs.Z1_PART.Value = "1359-441-1A-2326";
    Inputs.Z2_PART.Value = "1359-441-2A-2326";
    Inputs.Z3_PART.Value = "1359-441-0A-2648";
}

if (Inputs.HYBRID.Value == "24/25/49") {
    Inputs.Z1_PART.Value = "1359-441-1A-2425";
    Inputs.Z2_PART.Value = "1359-441-2A-2425";
    Inputs.Z3_PART.Value = "1359-441-0A-2549";
}

if (Inputs.HYBRID.Value == "25/24/50") {
    Inputs.Z1_PART.Value = "1359-441-1A-2524";
    Inputs.Z2_PART.Value = "1359-441-2A-2524";
    Inputs.Z3_PART.Value = "1359-441-0A-2450";
}


string[] HybridLowToothCountRatios = new string[] {
    "14/27/35",
    "14/24/33",
    "14/23/33",
    "16/23/35",
    "19/21/39",
    "20/20/40"
};
string ToothCountSpec = ( HybridLowToothCountRatios.Contains ( Inputs.HYBRID.Value ) ) ? "Low tooth count spec" : "High tooth count spec" ;
string YHybrid ;
YHybrid = ( ((Inputs.HYBRID.Value != "") && (Inputs.HYBRID.Value != "Unknown"))  
    ? ("Hybrid gears: Z1=" + Inputs.HYBRID.Value.Substring(0, 2) + ", Z2=" + Inputs.HYBRID.Value.Substring(3, 2) + ", Z3=" + Inputs.HYBRID.Value.Substring(6, 2)  + " - " + ToothCountSpec + CRLF3)
    : (""));
string OHybrid ;
OHybrid = ( ((Inputs.HYBRID.Value == "") ||  (Inputs.HYBRID.Value == "Unknown"))  ? ("Hybrid gear ratios" + CRLF3) : (""));



/* ****** AC PULLEY ****** */

string YACPulley ;
YACPulley = ( ((Inputs.AC_PULLEY.Value != "") && (Inputs.AC_PULLEY.Value != "Unknown")) 
? ( (Inputs.AC_PULLEY.Value == "Yes")  ? ("A/C pulley included" + CRLF3) : ("A/C Pulley excluded" + CRLF3))
: (""));
string OACPulley ;
OACPulley = ( ((Inputs.AC_PULLEY.Value == "") ||  (Inputs.AC_PULLEY.Value == "Unknown"))  ? ("A/C pulley included?" + CRLF3) : (""));


/* ****** Inputs.ALTERNATOR.Value ****** */

string YAlternator ;
YAlternator = ( (Inputs.ALTERNATOR.Value == "n/a")  ? ("") 
: ( (Inputs.ALTERNATOR.Value == "input bevel")  ? ("Alternator pulley located on " + Inputs.ALTERNATOR.Value + CRLF3 + "     * Is Alternator Mounting Kit (1159-942-100D) Required for this ||der?" + CRLF3) 
: ( (Inputs.ALTERNATOR.Value == "left hand side")  ? ("Alternator pulley located on " + Inputs.ALTERNATOR.Value + CRLF3 + "     * Is Alternator Mounting Kit (1159-942-100E) Required for this ||der?" + CRLF3) 
: (""))));
    
string OAlternator ;
OAlternator = ( ((Inputs.ALTERNATOR.Value == "") ||  (Inputs.ALTERNATOR.Value == "Unknown"))  ? ("Alternator pulley requirement*" + CRLF3) : (""));
    
string XAlternator ;
XAlternator = ( (Inputs.ALTERNATOR.Value == "No")  ? ("Alternator pulley" + CRLF3) : (""));



/* ****** CLUSTER BAFFLE ****** */

string YCBaffle ;
YCBaffle = ( (Inputs.CLUSTER_BAFFLE.Value == "n/a")  ? ("") 
: ( (Inputs.CLUSTER_BAFFLE.Value != "")  ? ("Fitted with " + Inputs.OIL_PUMP.Value + " cluster baffle" + CRLF3) : ("")));
    
string OCBaffle ;
OCBaffle = ( (Inputs.CLUSTER_BAFFLE.Value == "")  ? ("Cluster baffle type*" + CRLF3) : (""));
    
string XCBaffle ;
XCBaffle = ( (Inputs.CLUSTER_BAFFLE.Value == "None")  ? ("Cluster baffle" + CRLF3) : (""));



/* ****** COOLANT MANIFOLD ****** */

string YCManifold ;
YCManifold = ( (Inputs.MANIFOLD.Value == "n/a")  ? ("") 
: ( (Inputs.MANIFOLD.Value != "")  ? ("Fitted with " + Inputs.MANIFOLD.Value + " coolant manifold" + CRLF3) : ("")));
    
string OCManifold ;
OCManifold = ( (Inputs.MANIFOLD.Value == "")  ? ("Coolant manifold*" + CRLF3) : ("")); 

if (Inputs.MANIFOLD.Value == "standard") {
    Inputs.MANIFOLD_PART.Value = "1359-941-102A";
}
if ((Inputs.INSTALLATION.Value == "Porsche") && (Inputs.MANIFOLD.Value == "customer specific")) {
    Inputs.MANIFOLD_PART.Value = "1359-941-102B";
}



/* ****** TRANSPORT STAND ****** */

string YTransport ;
YTransport = ( (Inputs.TRANSPORT_STAND.Value == "n/a")  ? ("") 
: ( (Inputs.TRANSPORT_STAND.Value == "Yes")  ? ("Fitted with transport stand" + CRLF3) : ("")));
    
string OTransport ;
OTransport = ( (Inputs.TRANSPORT_STAND.Value == "")  ? ("Transport stand requirement*" + CRLF3) : (""));
    
string XTransport ;
XTransport = ( (Inputs.TRANSPORT_STAND.Value == "No")  ? ("Transport stand" + CRLF3) : (""));



/* ****** FLOOR MOUNT ****** */

string YFloor ;
YFloor = ( (Inputs.FLOOR_MOUNT.Value == "n/a")  ? ("") 
: ( (Inputs.FLOOR_MOUNT.Value == "Yes")  ? ("Fitted with floor mount housing" + CRLF3) : ("")));
    
string OFloor ;
OFloor = ( (Inputs.FLOOR_MOUNT.Value == "")  ? ("Floor mount housing requirement" + CRLF3) : (""));
    
string XFloor ;
XFloor = ( (Inputs.FLOOR_MOUNT.Value == "No")  ? ("Floor mount housing (Supplied with blanking plug)" + CRLF3) : (""));



/* ****** CATCH TANK & BLANKING PLATE ****** */



string YCatchTank ;
YCatchTank = ( ((Inputs.C_TANK_BLANK.Value == "Yes") && (Inputs.INTERNAL_C_TANK.Value == "Xtrac"))  ? ("Supplied with internal catch tank and blanking plate" + CRLF3) 
: ( ((Inputs.C_TANK_BLANK.Value == "Yes") && (Inputs.INTERNAL_C_TANK.Value == "Customer"))  ? ("Supplied with catch tank blanking plate and fitments for customer supplied internal catch tank" + CRLF3) 
: ( ((Inputs.C_TANK_BLANK.Value == "Yes") && (Inputs.INTERNAL_C_TANK.Value == "not required"))  ? ("Supplied with catch tank blanking plate only") 
: (""))));
    
string OCatchTank ;
OCatchTank = ( ((Inputs.C_TANK_BLANK.Value == "") ||  (Inputs.INTERNAL_C_TANK.Value == ""))  ? ("Catch tank requirements" + CRLF3) : (""));

string XCatchTank ;
XCatchTank = ( ((Inputs.C_TANK_BLANK.Value == "No") && (Inputs.INTERNAL_C_TANK.Value == "not required"))  ? ("Catch tank blanking plate" + CRLF3 + "Internal catch tank" + CRLF3) 
: ( (Inputs.C_TANK_BLANK.Value == "No")  ? ("Catch tank blanking plate" + CRLF3)
: ("")));
    
    


/* ****** Inputs.CLUTCH.Value SHAFT ****** */

string Clutchshaftpart ;
/* ****** 1359 - On-leave Inputs.CLUTCH_SHAFT.Value ****** */

if ((Inputs.INSTALLATION.Value == "Audi") && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000D";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

if ((Inputs.INSTALLATION.Value == "BMW" || Inputs.INSTALLATION.Value == "BMW - Test" ) && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-420-000F";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

if ((Inputs.INSTALLATION.Value == "GM") && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000H";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

if ((Inputs.INSTALLATION.Value == "HPD - Short") && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000B";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

if ((Inputs.INSTALLATION.Value == "HPD - Daytona") && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000B";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

if ((Inputs.INSTALLATION.Value == "Porsche") && (Inputs.CLUTCH_SHAFT.Value == "Yes")) {
    Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000D";
    Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
}

Clutchshaftpart = Inputs.CLUTCH_SHAFT_PART.Value;

string YClshaft ;
YClshaft = ( (Inputs.CLUTCH_SHAFT.Value == "n/a")  ? ("") 
: ( ((Inputs.CLUTCH_SHAFT.Value != "") && (Inputs.CLUTCH_SHAFT.Value != "TBC"))  ? ("Supplied with clutch shaft, part number " + Clutchshaftpart + CRLF3) 
: ("")));
    
string OClshaft ;
OClshaft = ( ((Inputs.CLUTCH_SHAFT.Value == "") ||  (Inputs.CLUTCH_SHAFT.Value == "TBC"))  ? ("Clutch shaft requirement*" + CRLF3) : (""));
    
string XClshaft ;
XClshaft = ( (Inputs.CLUTCH_SHAFT.Value == "No")  ? ("Clutch shaft" + CRLF3) : (""));

string PackingCrate ;
PackingCrate = ( (Inputs.PACKING_CRATE.Value == "Yes")  ? ("Packing Crate Required" + CRLF3) : (""));



/* ****** COMPILE TEXT ****** */

Inputs.YPAGE3.Value = YHybrid + YAlternator + YCBaffle + YTransport + YFloor + YCatchTank + YCManifold + YClshaft + PackingCrate;
Inputs.OPAGE3.Value = OHybrid + OAlternator + OCBaffle + OTransport + OFloor + OCatchTank + OCManifold + OClshaft;
Inputs.XPAGE3.Value = XAlternator + XCBaffle + XTransport + XFloor + XCatchTank + XClshaft;



/* ****** CALCULATE BUILD HOURS ****** */

decimal Build001 ; /* basic hours for minimum spec build */
Build001 = 36;

decimal Build002 ; /* spare */
Build002 = 0;

decimal Build003 ; /* cluster type */
Build003 = 0;

decimal Build004 ; /* number of ratios */
Build004 = 0;

decimal Build005 ; /* bevel type */
Build005 = 0;

decimal Build006 ; /* diff type */
Build006 = ( (Inputs.DIFF_TYPE.Value == "VCP")  ? (2.0m) : (0));

decimal Build007 ; /* output flanges */
Build007 = 0;

decimal Build008 ; /* output flange retaining kit */
Build008 = ( (Inputs.OUTFLANGE_RET_KIT.Value == "Yes")  ? (0.5m) : (0));

decimal Build009 ; /* potentiometer */
Build009 = ( (Inputs.POT_REQD.Value)  ? (0.25m) : (0));

decimal Build010 ; /* gearchange type */
Build010 = ( (Inputs.GEARCHANGE_TYPE.Value == "External AGS")  ? (0.5m) 
: ( (Inputs.GEARCHANGE_TYPE.Value == "Pneumatic")  ? (0.75m) 
: (0)));

decimal Build011 ; /* plunger type */
Build011 = ( (Inputs.GEAR_PLUNGER_TYPE.Value == "quick release")  ? (0.5m) : (0));

decimal Build012 ; /* drop gear housing */
Build012 = 0;

decimal Build013 ; /* Inputs.STARTER.Value */
Build013 = 0;

decimal Build014 ; /* Inputs.ALTERNATOR.Value */
Build014 = ( (Inputs.ALTERNATOR.Value == "Yes")  ? (1.5m) : (0));

decimal Build015 ; /* oil pump type */
Build015 = 0;

decimal Build016 ; /* aux Inputs.DRIVE.Value */
Build016 = ( (Inputs.AUX_DRIVE.Value == "Yes")  ? (0.5m) : (0));

decimal Build017 ; /* Inputs.CLUTCH.Value */
Build017 = 0;

decimal Build018 ; /* prop flange */
Build018 = 0;

decimal Build019 ; /* Inputs.DRIVE.Value shafts */
Build019 = 0;

decimal Build020 ; /* cross shaft */
Build020 = 0;

decimal Build021 ; /* Inputs.CLUTCH.Value shaft */
Build021 = 0;

decimal Build022 ; /* additional bellhousing */
Build022 = 0;

decimal Build023 ; /* spare */
Build023 = 0;

decimal Build024 ; /* spare */
Build024 = 0;

decimal Build025 ; /* spare */
Build025 = 0;

decimal Build026 ; /* spare */
Build026 = 0;

decimal Build027 ; /* spare */
Build027 = 0;

decimal Build028 ; /* spare */
Build028 = 0;

decimal Build029 ; /* spare */
Build029 = 0;

decimal Build030 ; /* spare */
Build030 = 0;

decimal Build031 ; /* spare */
Build031 = 0;

decimal Build032 ; /* spare */
Build032 = 0;

decimal Build033 ; /* spare */
Build033 = 0;

decimal Build034 ; /* spare */
Build034 = 0;

decimal Build035 ; /* spare */
Build035 = 0;

decimal Build036 ; /* spare */
Build036 = 0;

decimal Build037 ; /* spare */
Build037 = 0;

decimal Build038 ; /* spare */
Build038 = 0;

decimal Build039 ; /* spare */
Build039 = 0;

decimal Build040 ; /* spare */
Build040 = 0;

decimal Build041 ; /* spare */
Build041 = 0;

decimal Build042 ; /* spare */
Build042 = 0;

decimal Build043 ; /* spare */
Build043 = 0;

decimal Build044 ; /* spare */
Build044 = 0;

decimal Build045 ; /* spare */
Build045 = 0;

decimal Build046 ; /* spare */
Build046 = 0;

decimal Build047 ; /* spare */
Build047 = 0;

decimal Build048 ; /* spare */
Build048 = 0;

decimal Build049 ; /* spare */
Build049 = 0;

decimal Build050 ; /* included in basic hours */
Build050 = 0;

decimal Buildsum ; /* total build hours */
Buildsum = Build001 + Build002 + Build003 + Build004 + Build005 + Build006 + Build007 + Build008 + Build009 + 
Build010 + Build011 + Build012 + Build013 + Build014 + Build015 + Build016 + Build017 + Build018 + Build019 + 
Build020 + Build021 + Build022 + Build023 + Build024 + Build025 + Build026 + Build027 + Build028 + Build029 + 
Build030 + Build031 + Build032 + Build033 + Build034 + Build035 + Build036 + Build037 + Build038 + Build039 + 
Build040 + Build041 + Build042 + Build043 + Build044 + Build045 + Build046 + Build047 + Build048 + Build049 + Build050;

Inputs.BUILDHRS.Value = Buildsum;



/* ****** SET PART NUMBERS FOR PRICING ****** */

Inputs.PART_0010.Value = "";

Inputs.PART_0020.Value = ( (Inputs.FINISH_RATIO.Value == "Xtrem")  ? ("529-RATIOFIN-XTREM") 
: ( (Inputs.FINISH_RATIO.Value == "ground")  ? ("529-RATIOFIN-GRNXTREM") 
: ("")));

Inputs.PART_0030.Value = "";

Inputs.PART_0040.Value = ( (Inputs.FINISH_FINAL.Value == "Xtrem")  ? ("529-FDFINISH-XTREM") 
: (""));

Inputs.PART_0050.Value = "";

Inputs.PART_0060.Value = ( (Inputs.DIFF_TYPE.Value == "VCP")  ? ("529-DIFFTYPE-VCP") 
: (""));

Inputs.PART_0070.Value = "";

Inputs.PART_0080.Value = "";

Inputs.PART_0090.Value = "";

Inputs.PART_0100.Value = "";

Inputs.PART_0110.Value = "";

Inputs.PART_0120.Value = ( (Inputs.POT_TYPE.Value == "rotary")  ? ("00P-192-0080") 
: (""));

Inputs.PART_0130.Value = ( (Inputs.GEARCHANGE_TYPE.Value == "Pneumatic")  ? ("529-GEARCHANGE-PNEU") 
: (""));

Inputs.PART_0140.Value = ( (Inputs.LPOT_REQD.Value == "Yes")  ? ("00P-192-0080") 
: (""));

Inputs.PART_0150.Value = ( (Inputs.GEAR_PLUNGER_TYPE.Value == "quick release")  ? ("369-928-000A") 
: (""));

Inputs.PART_0160.Value = "";

Inputs.PART_0170.Value = "";

Inputs.PART_0180.Value = ( (Inputs.ALTERNATOR.Value == "Yes")  ? ("529-ALTOPTION-ALT") 
: (""));

Inputs.PART_0190.Value = "";

Inputs.PART_0200.Value = "";

Inputs.PART_0210.Value = "";

Inputs.PART_0220.Value = "";






/* ****** CRLF5 ****** */

string CRLF5 ;
CRLF5 = "\n";



/* ****** COMBINE Y BLOCKS ****** */

string YText ;
YText = "CONFIGURED PRODUCT SPECIFICATION" + CRLF5 + CRLF5 + "CONFIRMED DETAILS" + CRLF5 + Inputs.YPAGE1.Value + Inputs.YPAGE2.Value + Inputs.YPAGE3.Value;



/* ****** COMBINE O BLOCKS ****** */


string OHdg ;
OHdg = ( ((Inputs.OPAGE1.Value == "") && (Inputs.OPAGE2.Value == "") && (Inputs.OPAGE3.Value == ""))  ? ("") : ("DETAILS AWAITING CUSTOMER CONFIRMATION"));

string OText ;
OText = ( (OHdg == "")  ? ("") : (OHdg + CRLF5 + Inputs.OPAGE1.Value + Inputs.OPAGE2.Value + Inputs.OPAGE3.Value + CRLF5 + "* PLEASE NOTE THAT THE UNIT PRICE MAY CHANGE WHEN THESE DETAILS ARE CONFIRMED" + CRLF5));



/* ****** COMBINE X BLOCKS ****** */

string XHdg ;
XHdg = ( ((Inputs.XPAGE1.Value == "") && (Inputs.XPAGE2.Value == "") && (Inputs.XPAGE3.Value == ""))  ? ("") : ("OPTIONS / ITEMS NOT INCLUDED"));

string XText ;
XText = ( (XHdg == "")  ? ("") : (XHdg + CRLF5 + Inputs.XPAGE1.Value + Inputs.XPAGE2.Value + Inputs.XPAGE3.Value));



/* ****** COMBINE ALL BLOCKS ****** */

Inputs.COMBINED_TEXT.Value = YText + CRLF5 + OText + CRLF5 + XText;
