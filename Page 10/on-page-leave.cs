/* ****** 1159 - On-leave PAGE 10 Rev 0 ****** */

/* REV. 0	ORIGINAL */

/* ****** CRLF1 ****** */

string CRLF1 = "\n";
string Included;
string Excluded;
string TBC;

/* ****** RATIOS ****** */

// First/Second Ratio.
if (Inputs.FIRST_SECOND_RATIO.Value != "") {
    // If we have, then set the text
    string Laycode = Inputs.FIRST_SECOND_RATIO.Value.Substring(0, 1);
    Inputs.FIRST_PART.Value = "1359-42M-000A" + Laycode;

    // Add to Included list
    Included += "First gear ratio = " + Inputs.FIRST_RATIO.Value + CRLF1;
} else {
    // Otherwise add to TBC list
    TBC += "First gear ratio" + CRLF1;
}

if (Inputs.THIRD_RATIO.Value != "" && )   { "1359-42M-3A-" + Inputs.THIRD_RATIO.Value.Replace(":","")};
if (Inputs.FOURTH_RATIO.Value != "")  { "1359-42M-4A-" + Inputs.FOURTH_RATIO.Value.Replace(":","")};
if (Inputs.FIFTH_RATIO.Value != "")   { "1359-42M-4B-" + Inputs.FIFTH_RATIO.Value.Replace(":","")};
if (Inputs.SIXTH_RATIO.Value != "")   { "1359-42M-4B-" + Inputs.SIXTH_RATIO.Value.Replace(":","")};
if (Inputs.SEVENTH_RATIO.Value != "") { "1359-42M-4C-" + Inputs.SEVENTH_RATIO.Value.Replace(":","")};


string YFirst;
YFirst = (((Inputs.FIRST_RATIO.Value != "") && (Inputs.FIRST_RATIO.Value != "Unknown")) ? ("First gear ratio = " + Inputs.FIRST_RATIO.Value + CRLF1) : (""));
string OFirst;
OFirst = (((Inputs.FIRST_RATIO.Value == "") || (Inputs.FIRST_RATIO.Value == "Unknown")) ? ("First gear ratio" + CRLF1) : (""));

string YSecond;
YSecond = (((Inputs.SECOND_RATIO.Value != "") && (Inputs.SECOND_RATIO.Value != "Unknown")) ? ("Second gear ratio = " + Inputs.SECOND_RATIO.Value + CRLF1) : (""));
string OSecond;
OSecond = (((Inputs.SECOND_RATIO.Value == "") || (Inputs.SECOND_RATIO.Value == "Unknown")) ? ("Second gear ratio" + CRLF1) : (""));

string YThird;
YThird = (((Inputs.THIRD_RATIO.Value != "") && (Inputs.THIRD_RATIO.Value != "Unknown")) ? ("Third gear ratio = " + Inputs.THIRD_RATIO.Value + CRLF1) : (""));
string OThird;
OThird = (((Inputs.THIRD_RATIO.Value == "") || (Inputs.THIRD_RATIO.Value == "Unknown")) ? ("Third gear ratio" + CRLF1) : (""));

string YFourth;
YFourth = (((Inputs.FOURTH_RATIO.Value != "") && (Inputs.FOURTH_RATIO.Value != "Unknown")) ? ("Fourth gear ratio = " + Inputs.FOURTH_RATIO.Value + CRLF1) : (""));
string OFourth;
OFourth = (((Inputs.FOURTH_RATIO.Value == "") || (Inputs.FOURTH_RATIO.Value == "Unknown")) ? ("Fourth gear ratio" + CRLF1) : (""));

string YFifth;
YFifth = (((Inputs.FIFTH_RATIO.Value != "") && (Inputs.FIFTH_RATIO.Value != "Unknown")) ? ("Fifth gear ratio = " + Inputs.FIFTH_RATIO.Value + CRLF1) : (""));
string OFifth;
OFifth = (((Inputs.FIFTH_RATIO.Value == "") || (Inputs.FIFTH_RATIO.Value == "Unknown")) ? ("Fifth gear ratio" + CRLF1) : (""));

string YSixth;
YSixth = (((Inputs.SIXTH_RATIO.Value != "") && (Inputs.SIXTH_RATIO.Value != "Unknown")) ? ("Sixth gear ratio = " + Inputs.SIXTH_RATIO.Value + CRLF1) : (""));
string OSixth;
OSixth = (((Inputs.SIXTH_RATIO.Value == "") || (Inputs.SIXTH_RATIO.Value == "Unknown")) ? ("Sixth gear ratio" + CRLF1) : (""));

string YSeventh;
YSeventh = (((Inputs.SEVENTH_RATIO.Value != "") && (Inputs.SEVENTH_RATIO.Value != "Unknown") && (Inputs.SEVENTH_RATIO.Value != "n/a")) ? ("Seventh gear ratio = " + Inputs.SEVENTH_RATIO.Value + CRLF1) : (""));
string OSeventh;
OSeventh = (((Inputs.SEVENTH_RATIO.Value == "") || (Inputs.SEVENTH_RATIO.Value == "Unknown")) ? ("Seventh gear ratio" + CRLF1) : (""));

string YRFinish;
YRFinish = ((Inputs.FINISH_RATIO.Value != "") ? ("All ratios supplied with " + Inputs.FINISH_RATIO.Value + " surface finish" + CRLF1) : (""));
string ORFinish;
ORFinish = ((Inputs.FINISH_RATIO.Value == "") ? ("Ratio surface finish*" + CRLF1) : (""));



/* ****** FINAL Inputs.DRIVE.Value ****** */

Inputs.FINAL_PART.Value = ((Inputs.FINAL_RATIO.Value == "") ? ("") : ("1359-449-0A-" + Inputs.FINAL_RATIO.Value.Replace(":","")));

Inputs.MAINSHAFT_PART.Value = ((Inputs.FINAL_RATIO.Value == "") ? ("") : ("1359-422-0A-" + Inputs.FINAL_RATIO.Value.Replace(":","")));

string YFinal;
YFinal = (((Inputs.FINAL_RATIO.Value != "") && (Inputs.FINAL_RATIO.Value != "Unknown")) ? ("Final drive ratio = " + Inputs.FINAL_RATIO.Value + " supplied with " + Inputs.FINISH_FINAL.Value + " surface finish" + CRLF1) : (""));
string YMain;
YMain = (((Inputs.FINAL_RATIO.Value != "") && (Inputs.FINAL_RATIO.Value != "Unknown")) ? ("Mainshaft supplied with Xtrem surface finish" + CRLF1) : (""));
string OFinal;
OFinal = (((Inputs.FINAL_RATIO.Value == "") || (Inputs.FINAL_RATIO.Value == "Unknown")) ? ("Final drive ratio" + CRLF1) : (""));



/* ****** BEVELS ****** */

string YBevel;
YBevel = (((Inputs.BEVEL_RATIO.Value != "") && (Inputs.BEVEL_RATIO.Value != "Unknown")) ? (Inputs.BEVEL_TYPE.Value + " bevel gear set with " + Inputs.BEVEL_RATIO.Value + " ratio" + CRLF1) : (""));
string OBevel;
OBevel = (((Inputs.BEVEL_RATIO.Value == "") || (Inputs.BEVEL_RATIO.Value == "Unknown")) ? ("Bevel ratio" + CRLF1) : (""));



/* ****** COMPILE TEXT ****** */

Inputs.YPAGE1.Value = YFirst + YSecond + YThird + YFourth + YFifth + YSixth + YSeventh + YRFinish + YFinal + YBevel;
Inputs.OPAGE1.Value = OFirst + OSecond + OThird + OFourth + OFifth + OSixth + OSeventh + ORFinish + OFinal + OBevel;