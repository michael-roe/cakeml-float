(* IEEE 754 floating point operations *)

val zero = Double.fromWord(Word64.fromInt(0));

val posInf = Double.fromWord(Word64.fromInt(0x7ff0000000000000));

val negInf = Double.fromWord(Word64.fromInt(0xfff0000000000000));

fun isZero (x) = Double.= x zero;

fun isInfinite(x) = Double.= x negInf orelse Double.= x posInf;

fun isNaN(x) = not (Double.= x x);

fun floatToString(x) =
  if isZero(x) then "zero"
  else if isInfinite(x) then "infinity"
  else if isNaN(x) then "nan"
  else "finite";

floatToString(zero);

floatToString(Double.~ zero);

floatToString(posInf);

floatToString(negInf);

floatToString(Double./ zero zero);
