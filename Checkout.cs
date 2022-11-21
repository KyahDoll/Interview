double total = 0;
int counter = 0;


Console.WriteLine("How many items do you want to buy");
int numItems = Convert.ToInt32(Console.ReadLine());

double[] prices = new double[numItems];

while (counter < numItems)
{
    Console.Write($"Enter {counter + 1} item: ");
    prices[counter++] = Convert.ToDouble(Console.ReadLine());
}


foreach(double n in prices)
{
    total += n;
    total = Math.Round(total, 2);
}

Console.WriteLine($"Your total is ${total}");