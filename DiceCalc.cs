using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulation
{
    internal class DiceCalc
    {
        //Make the countNumbers array public to ensure it can be called in the first class. It only holds 0 - 12, to represent the results of rolling 2 dice
        public int[] countNumbers = new int[13];

        //Create the RollDice method
        public void RollDice(int count)
        {
            
            //Create a new random number variable
            Random rnd = new Random();

            //Create an array called 'results' to store the results of each roll 
            int[] results = new int[count];

            //For each element in the 'results' array, calculate the result of rolling two dice (AKA a number between 2 and 12)
            //Update the count of each number in the 'countNumber' array each time the 'results' array is updated
            for (int i = 0; i < count; i++)
            {
                results[i] = rnd.Next(1, 7) + rnd.Next(1, 7);
                countNumbers[results[i]]++;
            }
            for (int i = 2; i < countNumbers.Length; i++)
            {
                countNumbers[i] = (int)Math.Round((((double)countNumbers[i] / count) * 100), 0, MidpointRounding.AwayFromZero);
                //System.Console.WriteLine($"Percentage of {i}: {countNumbers[i]}%"); <-- Just in case you want to see the percentage as a number
            }
        }
    }
}