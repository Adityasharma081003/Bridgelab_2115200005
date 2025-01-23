using System;

class Distances
{
    static void Main(string[] args)
    {

        // Variable to take user input for distance
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        //Converting feet to yards
        double distanceInYards = distanceInFeet / 3;

        // Converting yards to miles
        double distanceInMiles = distanceInYards / 1760;

        // Results
        Console.WriteLine("The distance in yards is " + distanceInYards + " and in miles is " + distanceInMiles);
    }
}
