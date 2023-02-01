﻿Console.Write("Enter the first integer number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
// 4 and 8 rows are needed because Sqrt calculates only positive roots not negative
Num1 = Math.Abs(Num1);

Console.Write("Enter the second integer number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Num2 = Math.Abs(Num2);

if (Num1 == Math.Sqrt(Num2))
{
    Console.WriteLine($"{Num1} is square root of {Num2}");
}
else
{
    if (Num2 == Math.Sqrt(Num1))
    {
        Console.WriteLine($"{Num2} is square root of {Num1}");
    }
    else
    {
        Console.WriteLine("None of your numbers is a square root");
    }
}