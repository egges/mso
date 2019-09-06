using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // create a band
        Band band = new Band();

        // let the band make some noise
        band.MakeNoise();

        int totalCost = band.ComputeCost(6);
        Console.WriteLine("Total cost = " + totalCost);
    }
}
