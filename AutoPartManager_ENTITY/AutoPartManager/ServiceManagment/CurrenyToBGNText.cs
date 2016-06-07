using System;
using System.Globalization;
namespace ServiceManagment
{
    public static class NumberToEnglish
    {
        public static String changeNumericToWords(double numb)
        {
            String num = numb.ToString();
            return changeToWords(num, false);
        }
        public static String changeCurrencyToWords(String numb)
        {
            return changeToWords(numb, true);
        }
        public static String changeNumericToWords(String numb)
        {
            return changeToWords(numb, false);
        }
        public static String changeCurrencyToWords(double numb)
        {
            return changeToWords(numb.ToString(), true);
        }
        private static String changeToWords(String numb, bool isCurrency)
        {
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
            String endStr = (isCurrency) ? ("") : ("");
            try
            {
                char a = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                int decimalPlace = numb.IndexOf(",");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (points.Length == 1)
                        points = points + "0";
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = (isCurrency) ? (" и ") : ("point");// just to separate whole numbers from points/cents
                        endStr = (isCurrency) ? ("стотинки " + endStr) : ("");
                        pointStr = translateCents(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), "лева " + andStr, pointStr, endStr);
            }
            catch { ;}
            return val;
        }
        private static String translateWholeNumber(String number, bool IsHundred = false)
        {
            string word = "";
            try
            {
                bool NextHundr = false;
                bool beginsZero = false;//tests for 0XX
                bool isDone = false;//test if already translated
                double dblAmt = (Convert.ToDouble(number));
                //if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    if (beginsZero)
                    {
                        numDigits = numDigits - 1;
                        if (number.TrimStart('0').Length > 0)
                            number = number.TrimStart('0');
                        else
                            number = "0";
                        //strInput.TrimStart('0').Length > 0 ? strInput.TrimStart('0') : "0";
                    }
                    int pos = 0;//store digit grouping
                    String place = "";//digit grouping name:hundres,thousand,etc...
                    switch (numDigits)
                    {
                        case 1://ones' range
                            if (IsHundred)
                                word = OneHundr(number);
                            else
                                word = ones(number);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = tens(number);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            place = " и ";
                            NextHundr = true;
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " хиляди ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " милион ";
                            break;
                        case 10://Billions's range
                            pos = (numDigits % 10) + 1;
                            place = " билион ";
                            break;
                        //add extra case options for anything above Billion...
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos), NextHundr) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros
                        if (beginsZero) word = " и " + word.Trim();
                    }
                    
                    //ignore digit grouping names
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { ;}
            return word.Trim();
        }

        private static String translateWholeNumberCent(String number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX
                bool isDone = false;//test if already translated
                double dblAmt = (Convert.ToDouble(number));
                //if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    if (beginsZero)
                    {
                        numDigits = numDigits - 1;
                        if (number.TrimStart('0').Length > 0)
                            number = number.TrimStart('0');
                        else
                            number = "0";
                        //strInput.TrimStart('0').Length > 0 ? strInput.TrimStart('0') : "0";
                    }
                    int pos = 0;//store digit grouping
                    String place = "";//digit grouping name:hundres,thousand,etc...
                    switch (numDigits)
                    {
                        case 1://ones' range
                            word = onesCent(number);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = tens(number);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            place = " сто ";
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " хиляди ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " милион ";
                            break;
                        case 10://Billions's range
                            pos = (numDigits % 10) + 1;
                            place = " билион ";
                            break;
                        //add extra case options for anything above Billion...
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros
                        if (beginsZero) word = " и " + word.Trim();
                    }

                    //ignore digit grouping names
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { ;}
            return word.Trim();
        }

        private static String tens(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "десет";
                    break;
                case 11:
                    name = "единадесет";
                    break;
                case 12:
                    name = "дванадесет";
                    break;
                case 13:
                    name = "тринадесет";
                    break;
                case 14:
                    name = "четиринадесет";
                    break;
                case 15:
                    name = "петнадесет";
                    break;
                case 16:
                    name = "шестнадесет";
                    break;
                case 17:
                    name = "седемнадесет";
                    break;
                case 18:
                    name = "осемнадесет";
                    break;
                case 19:
                    name = "деветнадесет";
                    break;
                case 20:
                    name = "двадесет";
                    break;
                case 30:
                    name = "тридесет";
                    break;
                case 40:
                    name = "четиридесет";
                    break;
                case 50:
                    name = "петдесет";
                    break;
                case 60:
                    name = "шестдесет";
                    break;
                case 70:
                    name = "седемдесет";
                    break;
                case 80:
                    name = "осемдесет";
                    break;
                case 90:
                    name = "деветдесет";
                    break;
                default:
                    if (digt > 0)
                    {
                        name = tens(digit.Substring(0, 1) + "0") + " и " + ones(digit.Substring(1));
                    }
                    break;
            }
            return name;
        }

        private static String ones(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "един";
                    break;
                case 2:
                    name = "два";
                    break;
                case 3:
                    name = "три";
                    break;
                case 4:
                    name = "четири";
                    break;
                case 5:
                    name = "пет";
                    break;
                case 6:
                    name = "шест";
                    break;
                case 7:
                    name = "седем";
                    break;
                case 8:
                    name = "осем";
                    break;
                case 9:
                    name = "девет";
                    break;
            }
            return name;
        }


        private static String OneHundr(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "сто";
                    break;
                case 2:
                    name = "двеста";
                    break;
                case 3:
                    name = "триста";
                    break;
                case 4:
                    name = "четиристотин";
                    break;
                case 5:
                    name = "петстотин";
                    break;
                case 6:
                    name = "шестстотин";
                    break;
                case 7:
                    name = "седемстотин";
                    break;
                case 8:
                    name = "осемстотин";
                    break;
                case 9:
                    name = "деветстотин";
                    break;
            }
            return name;
        }

        private static String onesCent(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "една";
                    break;
                case 2:
                    name = "две";
                    break;
                case 3:
                    name = "три";
                    break;
                case 4:
                    name = "четири";
                    break;
                case 5:
                    name = "пет";
                    break;
                case 6:
                    name = "шест";
                    break;
                case 7:
                    name = "седем";
                    break;
                case 8:
                    name = "осем";
                    break;
                case 9:
                    name = "девет";
                    break;
            }
            return name;
        }

        private static String translateCents(String cents)
        {
            return translateWholeNumber(cents); ;
        }
    }
}