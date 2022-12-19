// CRLF
string CRLF1 = "\n";

// Output strings
string IncludedTxt = "";
string ExcludedTxt = "";
string TBCTxt = "";

// First/Second Ratio [String format is: "A 13:35 / 16:33"].
if (Inputs.FIRST_SECOND_RATIO.Value != "") {
    Inputs.FIRST_PART.Value = "1359-42M-000A" + Inputs.FIRST_SECOND_RATIO.Value.Substring(0, 1);
    IncludedTxt += "First gear ratio = " + Inputs.FIRST_RATIO.Value + CRLF1;
    IncludedTxt += "Second gear ratio = " + Inputs.SECOND_RATIO.Value + CRLF1;
} else { 
    TBCTxt += "First gear ratio" + CRLF1; 
    TBCTxt += "Second gear ratio" + CRLF1;
};

// Third Gear.
if (Inputs.THIRD_RATIO.Value != "") { 
    Inputs.THIRD_PART.Value = "1359-42M-3A-" + Inputs.THIRD_RATIO.Value.Replace(":","");
    IncludedTxt += "Third gear ratio = " + Inputs.THIRD_RATIO.Value + CRLF1;
} else {
    TBCTxt += "Third gear ratio" + CRLF1;
};

// Fourth Gear.
if (Inputs.FOURTH_RATIO.Value != "") { 
    Inputs.FOURTH_PART.Value = "1359-42M-4A-" + Inputs.FOURTH_RATIO.Value.Replace(":","");
    IncludedTxt += "Fourth gear ratio = " + Inputs.FOURTH_RATIO.Value + CRLF1;
} else {
    TBCTxt += "Fourth gear ratio" + CRLF1;
};

// Fifth Gear.
if (Inputs.FIFTH_RATIO.Value != "") { 
    Inputs.FIFTH_PART.Value = "1359-42M-4B-" + Inputs.FIFTH_RATIO.Value.Replace(":","");
    IncludedTxt += "Fifth gear ratio = " + Inputs.FIFTH_RATIO.Value + CRLF1;
} else {
    TBCTxt += "Fifth gear ratio" + CRLF1;
};

// Sixth Gear.
if (Inputs.SIXTH_RATIO.Value != "") {
    Inputs.SIXTH_PART.Value = "1359-42M-4B-" + Inputs.SIXTH_RATIO.Value.Replace(":","");
    IncludedTxt += "Sixth gear ratio = " + Inputs.SIXTH_RATIO.Value + CRLF1;
} else {
    TBCTxt += "Sixth gear ratio" + CRLF1;
};

// Seventh Gear.
if (Inputs.SEVENTH_RATIO.Value != "") {
    Inputs.SEVENTH_PART.Value = "1359-42M-4C-" + Inputs.SEVENTH_RATIO.Value.Replace(":","");
    IncludedTxt += "Seventh gear ratio = " + Inputs.SEVENTH_RATIO.Value + CRLF1;
} else {
    TBCTxt += "Seventh gear ratio" + CRLF1;
};

// Seventh Gear Type.
if (Inputs.SEVENTH_TYPE.Value != "") {
    IncludedTxt += Inputs.SEVENTH_TYPE.Value + " spec 7th gear" + CRLF1;
    Inputs.SEVENTH_DOG_TYPE.Value = Inputs.SEVENTH_TYPE.Value;
} else {
    TBCTxt += "Ratio surface finish*" + CRLF1;
}

// Ratio finish specification
if ( Inputs.FINISH_RATIO.Value != "" ) {
    IncludedTxt += "All ratios supplied with " + Inputs.FINISH_RATIO.Value + " surface finish" + CRLF1;
} else {
    TBCTxt += "7th gear dog spec" + CRLF1;
}

// Final Drive & Mainshaft.
if ( Inputs.FINAL_RATIO.Value != "" ) {
    Inputs.FINAL_PART.Value = "1359-449-0A-" + Inputs.FINAL_RATIO.Value.Replace(":","");
    Inputs.MAINSHAFT_PART.Value = "1359-422-0A-" + Inputs.FINAL_RATIO.Value.Replace(":","");
    IncludedTxt += "Final drive ratio = " + Inputs.FINAL_RATIO.Value + " supplied with " + Inputs.FINISH_FINAL.Value + " surface finish" + CRLF1;
    // IncludedTxt += "Mainshaft supplied with Xtrem surface finish" + CRLF1;
} else {
    TBCTxt += "Final drive ratio" + CRLF1;
}

// Bevel Gears.
if ( Inputs.BEVEL_RATIO.Value != "" ) {
    Inputs.BEVEL_PART.Value = "1359-425WPA-" + Inputs.BEVEL_RATIO.Value.Replace(":", "");
    IncludedTxt += Inputs.BEVEL_TYPE.Value + " bevel gear set with " + Inputs.BEVEL_RATIO.Value + " ratio" + CRLF1;
} else {
    TBCTxt += "Bevel ratio" + CRLF1;
}

// Compile text.
Inputs.YPAGE1.Value = IncludedTxt;
Inputs.OPAGE1.Value = TBCTxt;