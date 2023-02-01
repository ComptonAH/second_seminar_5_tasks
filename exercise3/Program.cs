Console.Write("Enter the first integer number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1%Num2==0)
{
    Console.WriteLine($"{Num2} is a divisible number to {Num1}");
}
else
{
    int Remainder = Num1%Num2;
    Console.WriteLine($"The remainder is {Remainder}");
}