include("functions.cscs");
i = 0;
for (i = 0; i < 13; i++) {
  b += (i*4 - 1);
  if ( i == 3) {
    break;
  } else {
    continue;
  }
  print("this is never reached");
}

a = 23; b = 22;
cond = "na";
if (a < b) {
  if (b < 15) {
    cond = "cond1";
  }
  elif  (b < 50) {
    cond = "cond2";
  }
}
elif (a >= 25) {
  cond = "cond3";
}
else {
  cond = "cond4";
}

function myp(par1, par2, par3 = 100) {
  return par1 + par2 + par3;
}
