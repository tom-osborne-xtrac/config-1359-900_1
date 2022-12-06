 /* ****** 1159 - On-leave Inputs.CUSTID.Value ****** */
 
 
 if (Inputs.CUSTID.Value == "LOTU07")
 {
 Inputs.DRAWING_VARIANT.Value = "1159-900-000D";
 Inputs.DESIGN_SPEC.Value = "1159D";
 Inputs.QTY_RATIOS.Value = "6";
 Inputs.FINISH_RATIO.Value = "ground";
 Inputs.BEVEL_RATIO.Value = "23:21";
 Inputs.DIFF_TYPE.Value = "ext. adjustable PPD";
 Inputs.OUTFLANGE_REQD.Value = "38mm";
 Inputs.GEARCHANGE_TYPE.Value = "MEGALine E-shift";
 Inputs.ALTERNATOR.Value = "left hand side";
 Inputs.CLUSTER_BAFFLE.Value = "GFRP";
 Inputs.SPEED_SENSOR.Value = "No";
 Inputs.FLOOR_MOUNT.Value = "No";
 Inputs.C_TANK_BLANK.Value = "Yes";
 Inputs.INTERNAL_C_TANK.Value = "Inputs.CUSTOMER.Value";
 }
 
 
 if (Inputs.CUSTID.Value == "SEBA01")
 {
 Inputs.DRAWING_VARIANT.Value = "1159-900-000B";
 Inputs.DESIGN_SPEC.Value = "1159B";
 Inputs.QTY_RATIOS.Value = "7";
 Inputs.FINISH_RATIO.Value = "ground";
 Inputs.BEVEL_RATIO.Value = "19:24";
 Inputs.DIFF_TYPE.Value = "ext. adjustable PPD";
 Inputs.OUTFLANGE_REQD.Value = "38mm";
 Inputs.GEARCHANGE_TYPE.Value = "MEGALine E-shift";
 Inputs.ALTERNATOR.Value = "input bevel";
 Inputs.CLUSTER_BAFFLE.Value = "CFRP";
 Inputs.SPEED_SENSOR.Value = "Yes";
 Inputs.FLOOR_MOUNT.Value = "Yes";
 Inputs.C_TANK_BLANK.Value = "Yes";
 Inputs.INTERNAL_C_TANK.Value = "Inputs.CUSTOMER.Value";
 }
 
 
 
 if ((Inputs.CUSTID.Value != "OREC01") && (Inputs.CUSTID.Value != "SEBA01") && (Inputs.CUSTID.Value != "LOTU07")) 
{
 Inputs.DRAWING_VARIANT.Value = "TBC (based on 1159-900-000B)";
 Inputs.CLUTCH_SHAFT_PART.Value = "(TBC)";
 }
