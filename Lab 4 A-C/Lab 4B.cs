
Console.WriteLine("Package A: For $9.95 per month, 10 audiobooks are provided. Additional books are $2.00 per book.");
Console.WriteLine("Package B: For $13.95 per month, 20 audiobooks are provided. Additional books are $1.00 per book.");
Console.WriteLine("Package C: For $19.95 per month, unlimited audiobook access is provided.");

double packageA = 9.95;
double packageB = 13.95;
double packageC = 19.95;
double extrabookA = 2.00;
double extrabookB = 1.00;
string userInput1;
double userInput2;
double total;



Console.WriteLine("What Subscription did you purchase?");
userInput1 = Console.ReadLine().ToLower();

Console.WriteLine("How many books did you read total?");
userInput2 = Convert.ToDouble(Console.ReadLine());

if (userInput1 == "packagea")
{
    total = packageA + (extrabookA * userInput2);
}
else if (userInput1 == "packageb")
{
    total = packageB + (extrabookB * userInput2);
}
else 
{
    total = packageC;
}
Console.WriteLine($"Your monthly total is ${total}");