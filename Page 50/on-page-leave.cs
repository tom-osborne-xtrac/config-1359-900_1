string CRLF3 = "\n";

string Included_Text = "";
string Excluded_Text = "";
string Job_Text = "";
string TBC_Text = "";

/* ****** HYBRID GEAR RATIOS ****** */
switch (Inputs.HYBRID.Value) {
    case "16/33/41":
        Inputs.Z1_PART.Value = "1359-441-1A-1633";
        Inputs.Z2_PART.Value = "1359-441-2A-1633";
        Inputs.Z3_PART.Value = "1359-441-0A-3341";
        break;

    case "17/32/42":
        Inputs.Z1_PART.Value = "1359-441-1A-1732";
        Inputs.Z2_PART.Value = "1359-441-2A-1732";
        Inputs.Z3_PART.Value = "1359-441-0A-3242";
        break;

    case "18/31/43":
        Inputs.Z1_PART.Value = "1359-441-1A-1831";
        Inputs.Z2_PART.Value = "1359-441-2A-1831";
        Inputs.Z3_PART.Value = "1359-441-0A-3143";
        break;
    
    case "19/30/44":
        Inputs.Z1_PART.Value = "1359-441-1A-1930";
        Inputs.Z2_PART.Value = "1359-441-2A-1930";
        Inputs.Z3_PART.Value = "1359-441-0A-3044";
        break;

    case "20/29/45":
        Inputs.Z1_PART.Value = "1359-441-1A-2029";
        Inputs.Z2_PART.Value = "1359-441-2A-2029";
        Inputs.Z3_PART.Value = "1359-441-0A-2945";
        break;

    case "21/28/46":
        Inputs.Z1_PART.Value = "1359-441-1A-2128";
        Inputs.Z2_PART.Value = "1359-441-2A-2128";
        Inputs.Z3_PART.Value = "1359-441-0A-2846";
        break;

    case "22/27/47":
        Inputs.Z1_PART.Value = "1359-441-1A-2227";
        Inputs.Z2_PART.Value = "1359-441-2A-2227";
        Inputs.Z3_PART.Value = "1359-441-0A-2747";
        break;

    case "23/26/48":
        Inputs.Z1_PART.Value = "1359-441-1A-2326";
        Inputs.Z2_PART.Value = "1359-441-2A-2326";
        Inputs.Z3_PART.Value = "1359-441-0A-2648";
        break;

    case "24/25/49":
        Inputs.Z1_PART.Value = "1359-441-1A-2425";
        Inputs.Z2_PART.Value = "1359-441-2A-2425";
        Inputs.Z3_PART.Value = "1359-441-0A-2549";
        break;
    
    case "25/24/50":
        Inputs.Z1_PART.Value = "1359-441-1A-2524";
        Inputs.Z2_PART.Value = "1359-441-2A-2524";
        Inputs.Z3_PART.Value = "1359-441-0A-2450";
        break;
}

string[] HybridLowToothCountRatios = new string[] {
    "14/27/35",
    "14/24/33",
    "14/23/33",
    "16/23/35",
    "19/21/39",
    "20/20/40"
};

if (Inputs.HYBRID.Value != "") {
    string z1 = "Z1=" + Inputs.HYBRID.Value.Substring(0, 2) + ", ";
    string z2 = "Z2=" + Inputs.HYBRID.Value.Substring(3, 2) + ", ";
    string z3 = "Z3=" + Inputs.HYBRID.Value.Substring(6, 2) + " - ";
    
    string ToothCountSpec = "High tooth count spec";
    if (HybridLowToothCountRatios.Contains(Inputs.HYBRID.Value)) {
        ToothCountSpec = "Low tooth count spec";
    }
    
    // Example output: "Hybrid gears: Z1=19, Z2=30, Z3=44 - High tooth count spec"
    Included_Text += "Hybrid gears: " + z1 + z2 + z3 + ToothCountSpec + CRLF3;
} else {
    TBC_Text += "Hybrid gear ratios" + CRLF3;
}

/* GEARCHANGE UNIT */
switch (Inputs.GEARCHANGE_UNIT.Value) {
    case "A/V ring only":
        Included_Text += "A/V rings included" + CRLF3;
        Job_Text += "Include 00P-190-1032A IVA A/V ring" + CRLF3;
        Excluded_Text += "Gearchange unit not included" + CRLF3;
        break;

    case "1254 IVA + A/V ring":
        Included_Text += "1254 IVA + A/V rings included." + CRLF3;
        Job_Text += "Fit 1254-932-000A + 00P-190-1032A to gearbox" + CRLF3;
        break;

    case "None":
        Excluded_Text += "Gearchange unit and A/V rings not included";
        break;

    default:
        TBC_Text += "Gearchange unit requirement*" + CRLF3;
        break;
}

/* ****** AC PULLEY ****** */
switch (Inputs.AC_PULLEY.Value) {
    case "Yes":
        Included_Text += "A/C pulley assembly included" + CRLF3;
        break;

    case "No":
        Included_Text += "A/C Pulley assemly excluded" + CRLF3;
        break;

    default:
        TBC_Text += "A/C pulley assembly included?" + CRLF3;
        break;
}

/* ****** CLUTCH SHAFT ****** */
if (Inputs.CLUTCH_SHAFT.Value == "Yes") {

    switch (Inputs.INSTALLATION.Value) {
        case "Audi":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000D";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;

        case "BMW": case "BMW - Test":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-420-000F";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;

        case "GM":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000H";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;

        case "HPD - Short":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000B";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;

        case "HPD - Daytona":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000B";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;

        case "Porsche":
            Inputs.CLUTCH_SHAFT_PART.Value = "1359-920-000D";
            Inputs.CSHAFT_RET_RING_PART.Value = "1359-420-001A";
            break;
    }

    Included_Text +=  "Supplied with clutch shaft, part number " + Inputs.CLUTCH_SHAFT_PART.Value + CRLF3;

} else if (Inputs.CLUTCH_SHAFT.Value == "No") {
    Excluded_Text +=  "Clutch shaft" + CRLF3;

} else {
    TBC_Text += "Clutch shaft requirement*" + CRLF3;
}

/* ****** BELL-HOUSING RING DOWELS ****** */
switch (Inputs.INCLUDEBELLHOUSINGDOWELS.Value) {
    case "Yes":
        Included_Text += "2-off loose ring dowels included with hybrid plate assembly" +CRLF3;
        Job_Text += "Include 2-off loose ring dowels with hybrid plate assembly" + CRLF3;
        break;

    case "No":
        Excluded_Text += "Bell-housing ring dowels excluded" +CRLF3;
        Job_Text += "Omit 2-off loose ring dowels from hybrid plate assembly" + CRLF3;
        break;

    default:
        TBC_Text += "Bell Housing ring dowels?" + CRLF3;
        break;
}

/* ****** COOLANT MANIFOLD ****** */
switch (Inputs.MANIFOLD.Value) {
    case "Standard kit with pipe studs":
        Included_Text += "Standard coolant manifold kit with studs" + CRLF3;
        Job_Text += "Fit 1359-941-102A manifold kit including 2-off 00P-482-004B studs" + CRLF3;
        Inputs.MANIFOLD_PART.Value = "1359-941-102A";
        break;

    case "Standard kit excluding pipe studs":
        Included_Text += "Standard coolant manifold kit without studs" + CRLF3;
        Job_Text += "Fit 1359-941-102A manifold kit, do not include 2-off 00P-482-004B studs" + CRLF3;
        Inputs.MANIFOLD_PART.Value = "1359-941-102A";
        break;

    case "Porsche specific kit":
        Included_Text += "Customer specific coolant manifold kit" + CRLF3;
        Job_Text += "Fit 1359-941-102B manifold kit" + CRLF3;
        Inputs.MANIFOLD_PART.Value = "1359-941-102B";
        break;

    default:
        TBC_Text += "Coolant manifold*" + CRLF3;
        break;
}

/* ****** OIL CATCH TANK ****** */
switch (Inputs.INTERNAL_C_TANK.Value) {
    case "Yes":
        Included_Text += "1L Oil catch tank included" + CRLF3;
        break;

    case "No":
        Excluded_Text += "1L Oil catch tank not included" + CRLF3;
        break;

    default:
        TBC_Text += "Oil catch tank*" + CRLF3;
        break;
}

/* ****** TETHER BRACKET ****** */
switch (Inputs.TETHER.Value) {
    case "Yes":
        Included_Text += "Tether bar assembly included" + CRLF3;
        break;

    case "No":
        Excluded_Text += "Tether bar assembly excluded" + CRLF3;
        break;

    default:
        TBC_Text += "Tether bar assembly" + CRLF3;
        break;
}


/* ****** AIR JACK TUBE  ****** */
switch (Inputs.AIR_JACK.Value) {
    case "Yes":
        Included_Text += "Air jack tube assembly included" + CRLF3;
        break;

    case "No":
        Excluded_Text += "Air jack tube assembly excluded" + CRLF3;
        break;

    default:
        TBC_Text += "Air jack tube assembly" + CRLF3;
        break;
}


/* ****** PACKING CRATE ****** */
switch (Inputs.PACKING_CRATE.Value) {
    case "Yes":
        Included_Text += "Packing Crate Required" + CRLF3;
        break;

    case "No":
        Excluded_Text += "Packing Crate excluded" + CRLF3;
        break;

    default:
        TBC_Text += "Packing Crate" + CRLF3;
        break;
}

/* ****** COMPILE TEXT ****** */
Inputs.YPAGE3.Value = Included_Text;
Inputs.OPAGE3.Value = TBC_Text;
Inputs.XPAGE3.Value = Excluded_Text;

/* ****** CRLF5 ****** */
string CRLF5 = "\n";

/* ****** COMBINE Y BLOCKS ****** */
string YText;
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
Inputs.JOB_TEXT.Value = Job_Text;

/* ****** CALCULATE BUILD HOURS ****** */

// decimal Build001 ; /* basic hours for minimum spec build */
// Build001 = 36;

// decimal Build002 ; /* spare */
// Build002 = 0;

// decimal Build003 ; /* cluster type */
// Build003 = 0;

// decimal Build004 ; /* number of ratios */
// Build004 = 0;

// decimal Build005 ; /* bevel type */
// Build005 = 0;

// decimal Build006 ; /* diff type */
// Build006 = ( (Inputs.DIFF_TYPE.Value == "VCP")  ? (2.0m) : (0));

// decimal Build007 ; /* output flanges */
// Build007 = 0;

// decimal Build008 ; /* output flange retaining kit */
// Build008 = ( (Inputs.OUTFLANGE_RET_KIT.Value == "Yes")  ? (0.5m) : (0));

// decimal Build009 ; /* potentiometer */
// Build009 = ( (Inputs.POT_REQD.Value)  ? (0.25m) : (0));

// decimal Build010 ; /* gearchange type */
// Build010 = ( (Inputs.GEARCHANGE_TYPE.Value == "External AGS")  ? (0.5m) 
// : ( (Inputs.GEARCHANGE_TYPE.Value == "Pneumatic")  ? (0.75m) 
// : (0)));

// decimal Build011 ; /* plunger type */
// Build011 = ( (Inputs.GEAR_PLUNGER_TYPE.Value == "quick release")  ? (0.5m) : (0));

// decimal Build012 ; /* drop gear housing */
// Build012 = 0;

// decimal Build013 ; /* Inputs.STARTER.Value */
// Build013 = 0;

// decimal Build014 ; /* Inputs.ALTERNATOR.Value */
// Build014 = ( (Inputs.ALTERNATOR.Value == "Yes")  ? (1.5m) : (0));

// decimal Build015 ; /* oil pump type */
// Build015 = 0;

// decimal Build016 ; /* aux Inputs.DRIVE.Value */
// Build016 = ( (Inputs.AUX_DRIVE.Value == "Yes")  ? (0.5m) : (0));

// decimal Build017 ; /* Inputs.CLUTCH.Value */
// Build017 = 0;

// decimal Build018 ; /* prop flange */
// Build018 = 0;

// decimal Build019 ; /* Inputs.DRIVE.Value shafts */
// Build019 = 0;

// decimal Build020 ; /* cross shaft */
// Build020 = 0;

// decimal Build021 ; /* Inputs.CLUTCH.Value shaft */
// Build021 = 0;

// decimal Build022 ; /* additional bellhousing */
// Build022 = 0;

// decimal Build023 ; /* spare */
// Build023 = 0;

// decimal Build024 ; /* spare */
// Build024 = 0;

// decimal Build025 ; /* spare */
// Build025 = 0;

// decimal Build026 ; /* spare */
// Build026 = 0;

// decimal Build027 ; /* spare */
// Build027 = 0;

// decimal Build028 ; /* spare */
// Build028 = 0;

// decimal Build029 ; /* spare */
// Build029 = 0;

// decimal Build030 ; /* spare */
// Build030 = 0;

// decimal Build031 ; /* spare */
// Build031 = 0;

// decimal Build032 ; /* spare */
// Build032 = 0;

// decimal Build033 ; /* spare */
// Build033 = 0;

// decimal Build034 ; /* spare */
// Build034 = 0;

// decimal Build035 ; /* spare */
// Build035 = 0;

// decimal Build036 ; /* spare */
// Build036 = 0;

// decimal Build037 ; /* spare */
// Build037 = 0;

// decimal Build038 ; /* spare */
// Build038 = 0;

// decimal Build039 ; /* spare */
// Build039 = 0;

// decimal Build040 ; /* spare */
// Build040 = 0;

// decimal Build041 ; /* spare */
// Build041 = 0;

// decimal Build042 ; /* spare */
// Build042 = 0;

// decimal Build043 ; /* spare */
// Build043 = 0;

// decimal Build044 ; /* spare */
// Build044 = 0;

// decimal Build045 ; /* spare */
// Build045 = 0;

// decimal Build046 ; /* spare */
// Build046 = 0;

// decimal Build047 ; /* spare */
// Build047 = 0;

// decimal Build048 ; /* spare */
// Build048 = 0;

// decimal Build049 ; /* spare */
// Build049 = 0;

// decimal Build050 ; /* included in basic hours */
// Build050 = 0;

// decimal Buildsum ; /* total build hours */
// Buildsum = Build001 + Build002 + Build003 + Build004 + Build005 + Build006 + Build007 + Build008 + Build009 + 
// Build010 + Build011 + Build012 + Build013 + Build014 + Build015 + Build016 + Build017 + Build018 + Build019 + 
// Build020 + Build021 + Build022 + Build023 + Build024 + Build025 + Build026 + Build027 + Build028 + Build029 + 
// Build030 + Build031 + Build032 + Build033 + Build034 + Build035 + Build036 + Build037 + Build038 + Build039 + 
// Build040 + Build041 + Build042 + Build043 + Build044 + Build045 + Build046 + Build047 + Build048 + Build049 + Build050;

// Inputs.BUILDHRS.Value = Buildsum;



// /* ****** SET PART NUMBERS FOR PRICING ****** */

// Inputs.PART_0010.Value = "";

// Inputs.PART_0020.Value = ( (Inputs.FINISH_RATIO.Value == "Xtrem")  ? ("529-RATIOFIN-XTREM") 
// : ( (Inputs.FINISH_RATIO.Value == "ground")  ? ("529-RATIOFIN-GRNXTREM") 
// : ("")));

// Inputs.PART_0030.Value = "";

// Inputs.PART_0040.Value = ( (Inputs.FINISH_FINAL.Value == "Xtrem")  ? ("529-FDFINISH-XTREM") 
// : (""));

// Inputs.PART_0050.Value = "";

// Inputs.PART_0060.Value = ( (Inputs.DIFF_TYPE.Value == "VCP")  ? ("529-DIFFTYPE-VCP") 
// : (""));

// Inputs.PART_0070.Value = "";

// Inputs.PART_0080.Value = "";

// Inputs.PART_0090.Value = "";

// Inputs.PART_0100.Value = "";

// Inputs.PART_0110.Value = "";

// Inputs.PART_0120.Value = ( (Inputs.POT_TYPE.Value == "rotary")  ? ("00P-192-0080") 
// : (""));

// Inputs.PART_0130.Value = ( (Inputs.GEARCHANGE_TYPE.Value == "Pneumatic")  ? ("529-GEARCHANGE-PNEU") 
// : (""));

// Inputs.PART_0140.Value = ( (Inputs.LPOT_REQD.Value == "Yes")  ? ("00P-192-0080") 
// : (""));

// Inputs.PART_0150.Value = ( (Inputs.GEAR_PLUNGER_TYPE.Value == "quick release")  ? ("369-928-000A") 
// : (""));

// Inputs.PART_0160.Value = "";

// Inputs.PART_0170.Value = "";

// Inputs.PART_0180.Value = ( (Inputs.ALTERNATOR.Value == "Yes")  ? ("529-ALTOPTION-ALT") 
// : (""));

// Inputs.PART_0190.Value = "";

// Inputs.PART_0200.Value = "";

// Inputs.PART_0210.Value = "";

// Inputs.PART_0220.Value = "";


