using System.Runtime.InteropServices;
using Mission2;

internal class Program
{
    //int totalRolls = 0;
    private static void Main(string[] args)
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
        //print the number
        for (int index = 0; index < rollResults.Length; index++)
        {
            int rollSum = rollResults[index];
            int product = rollSum * 100;
            int percent = product / totalRolls;
            string resultString = (index + 2) + ": ";

            //calculate the percentage of the times it was rolled
            //print an asterisk for each percent is was rolled
            for (int i = 0; i < percent; i++)
            {
                resultString = resultString + "*";
            }
            Console.WriteLine(resultString + "\n");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

}