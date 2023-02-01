int RandomNumber = new Random().Next(10,99);
Console.WriteLine(RandomNumber);

// First solution:
// int Remainder = RandomNumber%10;
// int Whole = RandomNumber/10;
// if (Whole > Remainder)
// {
//     Console.WriteLine($"The bigger digit is {Whole}");
// }
// else
// {
//     Console.WriteLine($"The bigger digit is {Remainder}");
// }

// Second solution:
// int Remainder = RandomNumber%10;
// int Whole = RandomNumber/10;

//Third solution (the most optimal):
int Max = Math.Max(RandomNumber%10,RandomNumber/10);
Console.WriteLine($"The bigger digit is {Max}");