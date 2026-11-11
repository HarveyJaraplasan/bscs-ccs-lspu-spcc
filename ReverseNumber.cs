using System;
using static System.Console;

class Program
{
    static void Main()
    {
        Write("Enter a number: ");
        int number = int.Parse(ReadLine());
        
        int reversedNumber = 0;
        int temp = number;

        while (temp > 0)
        {
            int remainder = temp % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            temp /= 10;
        }

        WriteLine("Reversed number: " + reversedNumber);
    }
}
