int RandomNumber = new Random().Next(100,999);
Console.WriteLine(RandomNumber);

Console.WriteLine($"{RandomNumber/100}{RandomNumber%10}");