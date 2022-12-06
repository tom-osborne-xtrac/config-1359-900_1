 /* ****** 1159 - On-leave PAGE 10 Rev 0 ****** */
 
 
 /* REV. 0	ORIGINAL */
 
 
 
 /* ****** CRLF1 ****** */
 
 string CRLF1;
 CRLF1 = "\n";
 
 
 
 /* ****** RATIOS ****** */
 
 string Laycode;
 Laycode = (((Inputs.FIRST_RATIO.Value == "13:35") && (Inputs.SECOND_RATIO.Value == "16:33")) ? ("A") 
 : (((Inputs.FIRST_RATIO.Value == "14:34") && (Inputs.SECOND_RATIO.Value == "16:32")) ? ("B") 
 : (((Inputs.FIRST_RATIO.Value == "14:34") && (Inputs.SECOND_RATIO.Value == "16:33")) ? ("C") 
 : (((Inputs.FIRST_RATIO.Value == "13:35") && (Inputs.SECOND_RATIO.Value == "15:33")) ? ("D") 
 : (((Inputs.FIRST_RATIO.Value == "13:37") && (Inputs.SECOND_RATIO.Value == "15:33")) ? ("E")	
 : (((Inputs.FIRST_RATIO.Value == "12:37") && (Inputs.SECOND_RATIO.Value == "14:33")) ? ("F")
 : (((Inputs.FIRST_RATIO.Value == "14:36") && (Inputs.SECOND_RATIO.Value == "15:33")) ? ("G")
 : (((Inputs.FIRST_RATIO.Value == "13:37") && (Inputs.SECOND_RATIO.Value == "14:32")) ? ("H")
 : (((Inputs.FIRST_RATIO.Value == "14:36") && (Inputs.SECOND_RATIO.Value == "16:33")) ? ("J")
 : (""))))))))));
 
 
 Inputs.FIRST_PART.Value = ((Laycode == "") ? ("") : ("1359-42M-000A" + Laycode));
 	
 Inputs.THIRD_PART.Value = ((Inputs.THIRD_RATIO.Value == "") ? ("") : ("1359-42M-3A-" + Inputs.THIRD_RATIO.Value.Replace(":","")));
 
 Inputs.FOURTH_PART.Value = ((Inputs.FOURTH_RATIO.Value == "") ? ("") : ("1359-42M-4A-" + Inputs.FOURTH_RATIO.Value.Replace(":","")));
 
 Inputs.FIFTH_PART.Value = ((Inputs.FIFTH_RATIO.Value == "") ? ("") : ("1359-42M-4B-" + Inputs.FIFTH_RATIO.Value.Replace(":","")));
 
 Inputs.SIXTH_PART.Value = ((Inputs.SIXTH_RATIO.Value == "") ? ("") : ("1359-42M-4B-" + Inputs.SIXTH_RATIO.Value.Replace(":","")));
 	
 Inputs.SEVENTH_PART.Value = ((Inputs.SEVENTH_RATIO.Value == "") ? ("") : ("1359-42M-4C-" + Inputs.SEVENTH_RATIO.Value.Replace(":","")));
 
 
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
