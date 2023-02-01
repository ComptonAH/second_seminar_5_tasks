Console.Write("Enter an integer number: ");
int Number = Convert.ToInt32(Console.ReadLine());

// First solution (is more detailed):
// if (Number%7==0)
// {
//     if (Number%23==0)
//     {
//        Console.WriteLine($"{Number} is a simultaneously divisible number of 7 and 23"); 
//     }
//     else
//     {
//         Console.WriteLine($"{Number} is not a divisible number of 23, but of 7"); 
//     }
    
// }
// else
// {
//     Console.WriteLine($"{Number} is not a divisible number of 7 and 23");
// }

//Second solution:
if (Number%7==0 && Number%23==0)
{
    Console.WriteLine($"{Number} is a simultaneously divisible number of 7 and 23"); 
}
else
{
    Console.WriteLine($"{Number} is NOT a simultaneously divisible number of 7 and 23"); 
}