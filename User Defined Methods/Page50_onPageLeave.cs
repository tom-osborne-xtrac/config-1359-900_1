string CRLF3 = "\n";

string Included_Text = "";
string Excluded_Text = "";
string Job_Text = "ASSEMBLY NOTES" + CRLF3;
string TBC_Text = "";

/* ****** HYBRID GEAR RATIOS ****** */
switch (Inputs.HYBRID.Value) {
    case "14/27/35":
        Inputs.Z1_PART.Value = "1359-441-1C-1427";
        Inputs.Z2_PART.Value = "1359-441-2B-1427";
        Inputs.Z3_PART.Value = "1359-441-0B-2735";
        break;

    case "14/24/33":
        Inputs.Z1_PART.Value = "1359-441-1C-1424";
        Inputs.Z2_PART.Value = "1359-441-2B-1424";
        Inputs.Z3_PART.Value = "1359-441-0B-2433";
        break;

    case "14/23/32":
        Inputs.Z1_PART.Value = "1359-441-1C-1423";
        Inputs.Z2_PART.Value = "1359-441-2B-1423";
        Inputs.Z3_PART.Value = "1359-441-0B-2332";
        break;

    case "16/23/35":
        Inputs.Z1_PART.Value = "1359-441-1C-1623";
        Inputs.Z2_PART.Value = "1359-441-2B-1623";
        Inputs.Z3_PART.Value = "1359-441-0B-2335";
        break;

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

    case "19/21/39":
        Inputs.Z1_PART.Value = "1359-441-1C-1921";
        Inputs.Z2_PART.Value = "1359-441-2B-1921";
        Inputs.Z3_PART.Value = "1359-441-0B-2139";
        break;

    case "19/30/44":
        Inputs.Z1_PART.Value = "1359-441-1A-1930";
        Inputs.Z2_PART.Value = "1359-441-2A-1930";
        Inputs.Z3_PART.Value = "1359-441-0A-3044";
        break;

    case "20/20/40":
        Inputs.Z1_PART.Value = "1359-441-1C-2020";
        Inputs.Z2_PART.Value = "1359-441-2B-2020";
        Inputs.Z3_PART.Value = "1359-441-0B-2040";
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
    Inputs.HYBRID_TOOTH_COUNT.Value = "high";
    if (HybridLowToothCountRatios.Contains(Inputs.HYBRID.Value)) {
        ToothCountSpec = "Low tooth count spec";
        Inputs.HYBRID_TOOTH_COUNT.Value = "low";
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
        Excluded_Text += "A/C Pulley assemly excluded" + CRLF3;
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
Inputs.COMBINED_TEXT.Value = YText + CRLF5 + OText + CRLF5 + XText + CRLF5 + Job_Text;