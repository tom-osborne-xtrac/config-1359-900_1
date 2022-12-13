string CRLF2 = "\n";
string DEG = "°";

/* ****** DIFF ****** */

string Ramps ;
Ramps = ( ((Inputs.DIFF_TYPE.Value == "nitrogen preload") || (Inputs.DIFF_TYPE.Value == "non-ext. adjustable PPD") || (Inputs.DIFF_TYPE.Value == "ext. adjustable PNPD")) ? ("Yes") : (""));

string Angles ;
Angles = ( ((Ramps == "Yes") && (Inputs.DRIVE.Value != "") && (Inputs.DRIVE.Value != "Unknown") && (Inputs.COAST.Value != "") && (Inputs.COAST.Value != "Unknown")) ? ("Yes") : (""));

string Discs ;
Discs = ( ((Inputs.DIFF_TYPE.Value == "nitrogen preload") || (Inputs.DIFF_TYPE.Value == "non-ext. adjustable PPD") || (Inputs.DIFF_TYPE.Value == "ext. adjustable PNPD")) ? ("Yes") : (""));



/* ****** RAMPS ****** */

string YRamps ;
YRamps = ( ((Ramps == "Yes") && (Angles == "Yes")) ? ( (Inputs.DIFF_TYPE.Value == "nitrogen preload") ? ("Nitrogen preload differential fitted with " + Inputs.DRIVE.Value + DEG + " DRIVE and " + Inputs.COAST.Value + DEG + " COAST ramp angles" + CRLF2)
: ( (Inputs.DIFF_TYPE.Value == "non-ext. adjustable PPD") ? ("Non-externally adjustable PPD fitted with " + Inputs.DRIVE.Value + DEG + " DRIVE and " + Inputs.COAST.Value + DEG + " COAST ramp angles" + CRLF2)
: ( (Inputs.DIFF_TYPE.Value == "ext. adjustable PNPD") ? ("Externally adjustable PNPD fitted with " + Inputs.DRIVE.Value + DEG + " DRIVE and " + Inputs.COAST.Value + DEG + " COAST ramp angles" + CRLF2)
: ( (Inputs.DIFF_TYPE.Value == "spool") ? ("Spool-type Differential" + CRLF2)
: ( ((Inputs.DIFF_TYPE.Value != "") && (Inputs.DIFF_TYPE.Value != "Unknown")) ? (Inputs.DIFF_TYPE.Value + "-type differential" + CRLF2) 
: (""))))))
: (""));
string ODiff ;
ODiff = ( ((Inputs.DIFF_TYPE.Value == "") || (Inputs.DIFF_TYPE.Value == "Unknown")) ? ("Differential type" + CRLF2) : (""));
string ORamps ;
ORamps = ( ((Ramps == "Yes") && (Angles != "Yes")) ? ("Ramp and cross-pin angles" + CRLF2) : (""));

Inputs.RAMP_PART.Value = ((Inputs.DRIVE.Value != "")  && (Inputs.DRIVE.Value != "Unknown") &&  (Inputs.COAST.Value != "") && (Inputs.COAST.Value != "Unknown")) ? ("1359-981-050A-" + Inputs.DRIVE.Value + Inputs.COAST.Value) : (""); 
// Inputs.RAMP_PART.Value =  PCLookUp.DataRowRange("1359Ramps", Inputs.DRIVE.Value + "/" + Inputs.COAST.Value, "DPartNum" , "DPartNum");
// Inputs.CROSS_PIN_PART.Value = PCLookUp.DataRowRange("1359Ramps", Inputs.DRIVE.Value + "/" + Inputs.COAST.Value, "CPartNum" , "CPartNum");


/* ****** XTREM RAMPS ****** */

string YXRamps ;
YXRamps = ( (Inputs.XTREM_RAMPS.Value == "Yes") ? ("Ramps supplied with Xtrem surface finish" + CRLF2)
: ("Ramps supplied with a standard surface finish" + CRLF2));



/* ****** FRICTION DISCS ****** */

string Disctype ;
Disctype = ( (Inputs.FRICTION_FACE_MATL.Value == "n/a") ? ("")
: ( ((Inputs.FRICTION_FACE_MATL.Value != "") && (Inputs.FRICTION_FACE_MATL.Value != "Unknown")) ? ("Supplied with " + Inputs.FRICTION_FACE_MATL.Value + " friction discs") : ("")));

string Faceqty ;
Faceqty = ( (Inputs.FRICTION_FACE_QTY.Value == "n/a") ? ("")
: ( ((Inputs.FRICTION_FACE_QTY.Value != "") && (Inputs.FRICTION_FACE_QTY.Value != "Unknown")) ? ("Friction discs configured to give " + Inputs.FRICTION_FACE_QTY.Value + " friction faces per side") : ("")));

string YDisctype ;
YDisctype = ( ((Disctype != "") && (Faceqty != "")) ? (Disctype + " configured to give " + Inputs.FRICTION_FACE_QTY.Value + " friction faces" + CRLF2) 
: ( ((Disctype != "") && (Faceqty == "")) ? (Disctype + CRLF2) 
: ( ((Disctype == "") && (Faceqty != "")) ? (Faceqty + CRLF2) 
: (""))));

string ODisctype ;
ODisctype = ( ((Discs == "") || (Inputs.DIFF_TYPE.Value == "Plate")) ? ("") 
: ( ((Disctype == "") && (Faceqty == "")) ? ("Friction disc material" + CRLF2 + "Number of friction faces" + CRLF2) 
: ( ((Disctype == "") && (Inputs.FRICTION_FACE_MATL.Value != "n/a") && (Faceqty != "")) ? ("Friction disc material" + CRLF2) 
: ( ((Disctype != "") && (Faceqty == "")) ? ("Number of friction faces" + CRLF2) 
: ("")))));


/* ****** PRELOAD ****** */

string YPreloadvalue ;
YPreloadvalue = ( ((Inputs.PRELOAD_REQD.Value == "Yes") && (Inputs.PRELOAD_VALUE.Value != "") && (Inputs.PRELOAD_VALUE.Value != "Unknown")) ? ("Preload setting: " + Inputs.PRELOAD_VALUE.Value + "Nm" + CRLF2) : (""));
string OPreloadvalue ;

OPreloadvalue = ( ((Inputs.PRELOAD_REQD.Value == "") || (Inputs.PRELOAD_REQD.Value == "Unknown")) ? ("Preload value" + CRLF2) 
: ( ((Inputs.PRELOAD_REQD.Value == "Yes") && ((Inputs.PRELOAD_VALUE.Value == "") || (Inputs.PRELOAD_VALUE.Value == "Unknown"))) ? ("Preload setting value" + CRLF2) 
: ("")));

string XPreloadvalue ;
XPreloadvalue = ( (Inputs.PRELOAD_REQD.Value == "No") ? ("Adjustable preload" + CRLF2) : (""));





/* ****** OUTPUT FLANGE RET KIT ****** */

string YFlangekit ;
YFlangekit = ( (Inputs.OUTFLANGE_REQD.Value != "") ? ("Supplied with " + Inputs.OUTFLANGE_REQD.Value + " for output flanges" + CRLF2) : (""));
string OFlangekit ;
OFlangekit = ( ((Inputs.OUTFLANGE_RET_KIT.Value == "") || (Inputs.OUTFLANGE_RET_KIT.Value == "Unknown")) ? ("Output flange requirement" + CRLF2) : (""));
string XFlangekit ;
XFlangekit = ( (Inputs.OUTFLANGE_RET_KIT.Value == "None") ? ("Output flanges" + CRLF2) : (""));



/* ****** POTENTIOMETER ****** */

string YPot ;
YPot = ( (Inputs.POT_REQD.Value) ? ("Supplied with additional potentiometer (LHS)" + CRLF2) : (""));
string OPot ;
OPot = (((Inputs.POT_REQD.Value) && (Inputs.POT_TYPE.Value == "")) ? ("Additional potentiometer requirement (LHS)" + CRLF2) 
: ( ((Inputs.POT_REQD.Value) && (Inputs.POT_TYPE.Value == "Unknown")) ? ("Additional potentiometer requirement (LHS)" + CRLF2) 
: ("")));
string XPot ;
XPot = ( (Inputs.POT_TYPE.Value == "n/a") ? ("") : ( (!Inputs.POT_REQD.Value) ? ("Additional potentiometer (LHS)" + CRLF2) : ("")));



/* ****** GEARCHANGE ****** */

string YGearchange ;
YGearchange = ( (Inputs.GEARCHANGE_TYPE.Value == "MEGALine E-shift") ? ("No gearchange unit supplied, " + Inputs.GEARCHANGE_TYPE.Value + " gearchange unit required" + CRLF2) 
: ( (Inputs.GEARCHANGE_TYPE.Value == "1154") ? ("Xtrac 1154 gearchange unit required" + CRLF2 + "     * Is 1154-932-000CD required to be included in this order?")
: ( (Inputs.GEARCHANGE_TYPE.Value == "1254") ? ("Xtrac 1254 gearchange unit required" + CRLF2 + "     * Is 1254-932-000B required to be included in this order?")
: (""))));
string OGearchange ;
OGearchange = ( ((Inputs.GEARCHANGE_TYPE.Value == "") || (Inputs.GEARCHANGE_TYPE.Value == "Unknown")) ? ("Gearchange type" + CRLF2) 
: ( ((Inputs.GEARCHANGE_TYPE.Value == "Manual") && (Inputs.GEAR_PLUNGER_TYPE.Value == "")) ? ("Gearchange plunger type" + CRLF2) 
: ("")));



/* ****** COMPILE TEXT ****** */

Inputs.YPAGE2.Value = (YRamps + YXRamps + YDisctype + YPreloadvalue + YFlangekit + YPot + YGearchange);
Inputs.OPAGE2.Value = (ODiff + ORamps + ODisctype + OPreloadvalue + OFlangekit + OPot + OGearchange);
Inputs.XPAGE2.Value = (XPreloadvalue + XFlangekit + XPot);
