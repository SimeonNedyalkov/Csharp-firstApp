// Guess the number
int myNum = 3;
Console.WriteLine("Write a number between 1-10");
int input = int.Parse(Console.ReadLine());

if (myNum == input)
{
    Console.WriteLine("Correct !!!");
}
else
{
    Console.WriteLine("Sorry, you are wrong!");
}

Console.ReadKey();