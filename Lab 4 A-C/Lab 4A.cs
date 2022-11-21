/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab 4A
 * 	Project name: Lab 4
 *--------------------------------------------------------------------
 * Author’s name and email:	 Kyah Dollinger / Dollinger@etsu.edu			
 *          Course-Section: CSCI 1250-800
 *           Creation Date:	 9/29/22		
 * -------------------------------------------------------------------
 */



const double steel = 16400;
const double water = 4900;
const double air = 1100;
double distance;
string userInput;
double time = 0;

Console.WriteLine("What Material is the sound traveling through? Air, Water, or Steel?");
userInput = Console.ReadLine();
Console.WriteLine("How far, in feet, is the sound traveling?");
distance = Convert.ToInt32(Console.ReadLine());

if (userInput == "steel" || userInput == "Steel")
{
    time = distance / steel;
}
else if (userInput == "air" || userInput == "Air")
{
    time = distance / air;
}
else if (userInput == "water" || userInput == "Water")
{
    time = distance / water;
}
Console.WriteLine("The time to travel through the material at that distance is " + Math.Round(time, 2) + " seconds.");