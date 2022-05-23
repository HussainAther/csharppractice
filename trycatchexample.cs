function myp(par1, par2, par3 = 100) {
  return par1 + par2 + par3;
}

z = myp(par2=20, par1=70); // z = 190

try {
  z = myp(par2=20);
  print("Error. Missing Exception: Function [myp] arguments mismatch: 3 declared, 1 supplied.");
} catch(exc) {
  print("OK. Caught: " + exc);
}
try {
  z = myp(par2=20, par3=70);
  print("Error. Missing Exception: No argument [par1] given for function [myp].");
} catch(exc) {
  print("OK. Caught: " + exc);
}
