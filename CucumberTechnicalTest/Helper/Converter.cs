using System;

namespace CucumberTechnicalTest.Helper
{
    public static class Converter
    {        
        /// <summary>
        /// This method receive a decimal value
        /// </summary>
        /// <returns>The value writed in words</returns>
        public static String ConvertToWords(decimal value)
        {
            if (value <= 0 | value >= 1000000000000000)
            {
                return "Value is not supported.";
            }
            else
            {
                String strValue = value.ToString("000000000000000.00");
                String value_as_words = String.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    value_as_words += WriteWord(Convert.ToDecimal(strValue.Substring(i, 3)));
                    if (i == 0 & value_as_words != String.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(0, 3)) == 1)
                        {
                            value_as_words += " TRILLION" + ((Convert.ToDecimal(strValue.Substring(3, 12)) > 0) ? " AND " : String.Empty);
                        }
                        else if (Convert.ToInt32(strValue.Substring(0, 3)) > 1)
                        {
                            value_as_words += " TRILLIONS" + ((Convert.ToDecimal(strValue.Substring(3, 12)) > 0) ? " AND " : String.Empty);
                        }
                    }
                    else if (i == 3 & value_as_words != String.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(3, 3)) == 1)
                        {
                            value_as_words += " BILLION" + ((Convert.ToDecimal(strValue.Substring(6, 9)) > 0) ? " AND " : String.Empty);
                        }
                        else if (Convert.ToInt32(strValue.Substring(3, 3)) > 1)
                        {
                            value_as_words += " BILLIONS" + ((Convert.ToDecimal(strValue.Substring(6, 9)) > 0) ? " AND " : String.Empty);
                        }
                    }
                    else if (i == 6 & value_as_words != String.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(6, 3)) == 1)
                        {
                            value_as_words += " MILLION" + ((Convert.ToDecimal(strValue.Substring(9, 6)) > 0) ? " AND " : String.Empty);
                        }
                        else if (Convert.ToInt32(strValue.Substring(6, 3)) > 1)
                        {
                            value_as_words += " MILLIONS" + ((Convert.ToDecimal(strValue.Substring(9, 6)) > 0) ? " AND " : String.Empty);
                        }
                    }
                    else if (i == 9 & value_as_words != String.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(9, 3)) > 0)
                        {
                            value_as_words += " THOUSAND" + ((Convert.ToDecimal(strValue.Substring(12, 3)) > 0) ? " AND " : String.Empty);
                        }
                    }
                    if (i == 12)
                    {
                        if (value_as_words.Length > 8)
                        {
                            if (value_as_words.Substring(value_as_words.Length - 6, 6) == "BILLION" | value_as_words.Substring(value_as_words.Length - 6, 6) == "MILLION")
                            {
                                value_as_words += " ";
                            }
                            else if (value_as_words.Substring(value_as_words.Length - 7, 7) == "BILLIONS"
                                | value_as_words.Substring(value_as_words.Length - 7, 7) == "MILLIONS"
                                | value_as_words.Substring(value_as_words.Length - 8, 7) == "TRILLIONS")
                            {
                                value_as_words += " ";
                            }
                            else if (value_as_words.Substring(value_as_words.Length - 8, 8) == "TRILLIONS")
                            {
                                value_as_words += " ";
                            }
                        }
                        if (Convert.ToInt64(strValue.Substring(0, 15)) == 1)
                        {
                            value_as_words += " DOLLAR";
                        }
                        else if (Convert.ToInt64(strValue.Substring(0, 15)) > 1)
                        {
                            value_as_words += " DOLLARS";
                        }
                        if (Convert.ToInt32(strValue.Substring(16, 2)) > 0 && value_as_words != String.Empty)
                        {
                            value_as_words += " AND ";
                        }
                    }
                    if (i == 15)
                    {
                        if (Convert.ToInt32(strValue.Substring(16, 2)) == 1)
                        {
                            value_as_words += " CENT";
                        }
                        else if (Convert.ToInt32(strValue.Substring(16, 2)) > 1)
                        {
                            value_as_words += " CENTS";
                        }
                    }
                }
                return value_as_words;
            }
        }

        private static String WriteWord(decimal value)
        {
            if (value <= 0)
            {
                return String.Empty;
            }
            else
            {
                String builtResult = String.Empty;
                if (value > 0 & value < 1)
                {
                    value *= 100;
                }
                String strValor = value.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) builtResult += "ONE HUNDRED";
                else if (a == 2) builtResult += "TWO HUNDRED";
                else if (a == 3) builtResult += "THREE HUNDRED";
                else if (a == 4) builtResult += "FOUR HUNDRED";
                else if (a == 5) builtResult += "FIVE HUNDRED";
                else if (a == 6) builtResult += "SIX HUNDRED";
                else if (a == 7) builtResult += "SEVEN HUNDRED";
                else if (a == 8) builtResult += "EIGHT HUNDRED";
                else if (a == 9) builtResult += "NINE HUNDRED";
                if (b == 1)
                {
                    if (c == 0) builtResult += ((a > 0) ? " AND " : String.Empty) + "TEN";
                    else if (c == 1) builtResult += ((a > 0) ? " AND " : String.Empty) + "ELEVEN";
                    else if (c == 2) builtResult += ((a > 0) ? " AND " : String.Empty) + "TWELVE";
                    else if (c == 3) builtResult += ((a > 0) ? " AND " : String.Empty) + "THIRTEEN";
                    else if (c == 4) builtResult += ((a > 0) ? " AND " : String.Empty) + "FOURTEEN";
                    else if (c == 5) builtResult += ((a > 0) ? " AND " : String.Empty) + "FIFTEEN";
                    else if (c == 6) builtResult += ((a > 0) ? " AND " : String.Empty) + "SIXTEEN";
                    else if (c == 7) builtResult += ((a > 0) ? " AND " : String.Empty) + "SEVENTEEN";
                    else if (c == 8) builtResult += ((a > 0) ? " AND " : String.Empty) + "EIGHTEEN";
                    else if (c == 9) builtResult += ((a > 0) ? " AND " : String.Empty) + "NINETEEN";
                }
                else if (b == 2) builtResult += ((a > 0) ? " AND " : String.Empty) + "TWENTY";
                else if (b == 3) builtResult += ((a > 0) ? " AND " : String.Empty) + "THIRTY";
                else if (b == 4) builtResult += ((a > 0) ? " AND " : String.Empty) + "FORTY";
                else if (b == 5) builtResult += ((a > 0) ? " AND " : String.Empty) + "FIFTY";
                else if (b == 6) builtResult += ((a > 0) ? " AND " : String.Empty) + "SIXTY";
                else if (b == 7) builtResult += ((a > 0) ? " AND " : String.Empty) + "SEVENTY";
                else if (b == 8) builtResult += ((a > 0) ? " AND " : String.Empty) + "EIGHTY";
                else if (b == 9) builtResult += ((a > 0) ? " AND " : String.Empty) + "NINETY";
                if (strValor.Substring(1, 1) != "1" & c != 0 & builtResult != String.Empty) builtResult += "-";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) builtResult += "ONE";
                    else if (c == 2) builtResult += "TWO";
                    else if (c == 3) builtResult += "THREE";
                    else if (c == 4) builtResult += "FOUR";
                    else if (c == 5) builtResult += "FIVE";
                    else if (c == 6) builtResult += "SIX";
                    else if (c == 7) builtResult += "SEVEN";
                    else if (c == 8) builtResult += "EIGHT";
                    else if (c == 9) builtResult += "NINE";
                return builtResult;
            }
        }
    }
}
