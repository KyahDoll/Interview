
Console.WriteLine("$00.10 each for less than 20 checks");
Console.WriteLine("$00.08 each for 20-39 checks");
Console.WriteLine("$00.06 each for 40-59 checks.");
Console.WriteLine("$00.04 each for 60+ checks");

double priceA = 00.10;
double priceB = 00.08;
double priceC = 00.06;
double priceD = 00.06;

double userInput1;

double total = 0;

Console.WriteLine("How Many stamps would you like to purchase?");
userInput1 = Convert.ToInt32(Console.ReadLine().ToLower());

if (userInput1 <= 20 )
{
    total = userInput1 * priceA;
}
else if (userInput1 >= 20 || userInput1 <= 39)
{
    total = userInput1 * priceB;
}
else if (userInput1 >= 40 || userInput1 <= 59)
{
    total = userInput1 * priceC;
}
else if (userInput1 >= 60)
{
    total = userInput1 * priceD;
}

Console.WriteLine($"You are purchasing {userInput1} for a total of ${Math.Round(total, 2)} ");