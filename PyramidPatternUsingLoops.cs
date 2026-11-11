using System;
using static System.Console;

class Program
{
    static void Main()
    {
        char choice;

        do
        {
            Write("Enter the number of rows for the pyramid: ");
            int rows = int.Parse(ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Write("*");
                }

                WriteLine();
            }

            Write("Do you want to generate another pyramid? (y/n): ");
            choice = char.Parse(ReadLine().ToLower());
            WriteLine();

        } while (choice == 'y');
    }
}
