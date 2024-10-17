string rocket = """
        /\\
       /  \\
      /    \\
     /      \\
    /        \\
   /__________\\
    |        |
    |  O O   |
    |        |
    |________|
       |  |
       |  |
      /____\\
     |      |
     |______|
""";
for (int i=0; i < 10; i++)
{
    Console.Clear();
    Console.WriteLine(rocket);
    Thread.Sleep(1000);
    rocket = "\r\n" + rocket;
    

};
Console.ReadKey();