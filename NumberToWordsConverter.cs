namespace technologyone_asset
{
    public static class NumberToWordsConverter
    {
        private static string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private static string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static string[] thousands = { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion" };

        public static string Convert(decimal number)
        {
            if (number == 0) return "Zero";

            if (number < 0) return "Minus " + Convert(-number);

            string words = "";

            int intPart = (int)number;
            int decimalPart = (int)((number - intPart) * 100);

            for (int i = 0; i < thousands.Length; i++)
            {
                int currentPart = intPart % 1000;
                if (currentPart > 0)
                {
                    words = ConvertHundreds(currentPart) + thousands[i] + " " + words;
                }
                intPart /= 1000;
            }

            words = words.Trim();

            if (decimalPart > 0)
            {
                words += " and " + ConvertHundreds(decimalPart) + " Cents";
            }

            return words;
        }

        private static string ConvertHundreds(int number)
        {
            string words = "";

            if ((number / 100) > 0)
            {
                words += units[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += teens[number - 10];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + units[number % 10];
                }
            }

            return words.Trim();
        }
    }

}
