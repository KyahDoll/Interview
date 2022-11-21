Console.WriteLine("Do you wish to Continue Yes or No?");
char userChoice =Convert.ToChar(Console.ReadLine().ToUpper()[0]);

while ((userChoice != 'Y') && (userChoice != 'N'))
{
    Console.Write("That is not a valid input.");
    Console.Write("Please try that again.");
    Console.WriteLine("Do you wish to Continue Yes or No?");
    userChoice = Convert.ToChar(Console.ReadLine().ToUpper()[0]);
}

if (userChoice =='Y')
{
    Console.Write("Thank you, please continue");

}

else
{
    Console.WriteLine("Thank you, Have a wonderful day");
}

