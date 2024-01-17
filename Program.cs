using DiceSimulation;

public class Program
{
    private static void Main(string[] args)
    {
        //New DiceCalc instance
        DiceCalc dc = new DiceCalc();

        //Establish count integer
        int count = 0;

        //Set count to user-input
        System.Console.WriteLine("Welcome to the dice throwing simulator!\nHow many rolls would you like to simulate?\n*NOTE: This simulates the throwing of 2 dice.");
        count = int.Parse(System.Console.ReadLine());

        //Call the RollDice method in the dc class instance and pass it the 'count' variable
        dc.RollDice(count);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + count + ".\n");

        //Create a new string using the constructor to repeat the '*' character dc.countNumbers[i] number of times
        for (int i = 2; i < dc.countNumbers.Length; i++)
        {
            System.Console.WriteLine($"{i}: {new string('*', dc.countNumbers[i])}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}