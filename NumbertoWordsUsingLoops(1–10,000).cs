
using System;
using static System.Console;

class Program
{
    static void Main()
    {
        while (true)
        {
            Write("Enter a whole number from 1 to 10,000 (or type 'exit' to quit):\n");
            string input = ReadLine();

            if (input == null || input.Trim().ToLower() == "exit")
                break;

            int number;

            if (!int.TryParse(input.Trim(), out number) || number < 1 || number > 10000)
            {
                WriteLine("Invalid input. Please enter a number between 1 and 10,000.");
                continue;
            }

            int value = number;
            string result = "";

            string[] digits = {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };

            string[] special = {
                "ten", "eleven", "twelve", "thirteen", "fourteen",
                "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };

            string[] decades = {
                "", "", "twenty", "thirty", "forty",
                "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            // Convert thousands
            if (value >= 10000)
            {
                result = "ten thousand";
                value = 0;
            }
            else if (value >= 1000)
            {
                result = digits[value / 1000] + " thousand";
                value %= 1000;
            }

            // Convert hundreds
            if (value / 100 > 0)
            {
                if (result.Length > 0)
                    result += " ";

                result += digits[value / 100] + " hundred";
                value %= 100;
            }

            // Convert remaining numbers
            if (value > 0)
            {
                if (result.Length > 0)
                    result += " and ";

                if (value < 20 && value >= 10)
                {
                    result += special[value - 10];
                }
                else
                {
                    if (value >= 20)
                    {
                        result += decades[value / 10];
                        value %= 10;

                        if (value > 0)
                            result += " ";
                    }

                    if (value > 0)
                        result += digits[value];
                }
            }

            WriteLine("The number " + number + " in words is: " + result);
        }
    }
}
