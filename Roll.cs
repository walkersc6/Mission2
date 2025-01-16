using System;

namespace Mission2
{
    internal class Roll
	{
        //create array to store the results of the dice rolls
        public int[] results = new int[11];

        //initialize each element in the array to be 0 before the dice rolling begins
        public Roll()
        {
            for (int Count = 0; Count < 11; Count++)
            {
                results[Count] = 0;
            }
        }

		public int[] rollDice(int totalRolls)
		{
            Random rnd = new Random();
           
            for (int Count = 0; Count < totalRolls; Count++)
            {
                //roll first dice
                int dice1 = rnd.Next(0, 6) + 1;

                //roll second dice
                int dice2 = rnd.Next(0, 6) + 1;

                //save sum of dice rolls
                int rollSum = dice1 + dice2;

                //store result
                results[rollSum - 2] = results[rollSum - 2] + 1;
            }

            //pass back to first class
            return results;
        }
    }
}