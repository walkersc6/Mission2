using System.Runtime.InteropServices;
using Mission2;

internal class Program
{
    private static void Main()
    {
        Roll r = new Roll();

        //ask user for desired number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        //get input
        int totalRolls = int.Parse(Console.ReadLine());

        //call 2nd class to roll the dice
        int[] rollResults = r.rollDice(totalRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + totalRolls + ".\n");

        //for each number possible to be rolled
        for (int index = 0; index < rollResults.Length; index++)
        {
            //calculate the percentage of the times it was rolled
            int rollSum = rollResults[index];
            int product = rollSum * 100;
            int percent = product / totalRolls;

            //print the number
            string resultString = (index + 2) + ": ";

            //print an asterisk for each percent is was rolled
            for (int i = 0; i < percent; i++)
            {
                resultString = resultString + "*";
            }

            //print results with a new line
            Console.WriteLine(resultString + "\n");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}