double myNumber = 0;
double myNumber2 = 0;
Console.WriteLine("Enter a Number: ");
double input = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a Number: ");
double input2 = double.Parse(Console.ReadLine());
double result = input + input2;
Console.WriteLine($"You have entered : {input} and {input2}. The total sum is: {result}");
Console.ReadKey();