using System;

public class Program
{
    public static void Main()
    {
        int number;
        string numberString, maxNumber = "";
        do
        {
            Console.Write("Введiть додатне тризначне число: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number < 100 | number >= 1000);

        numberString = Convert.ToString(number);

        for (int i = 0; i < 3; i++)
        {
            maxNumber = maxNumber + numberString.Max();
            string numberString2 = "";
            for (int n = 0; n < numberString.Length;  n++) 
            {
                if (numberString[n] != numberString.Max())
                {
                    numberString2 = numberString2 + numberString[n];
                }
            }
            numberString = numberString2;

        }

        Console.WriteLine(maxNumber);
    }
}