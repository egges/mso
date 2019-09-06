using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // create a band
        Band band = new Band();

        // register the creator objects
        band.RegisterMusicianCreator(new DrummerCreator());
        band.RegisterMusicianCreator(new BassPlayerCreator());
        band.RegisterMusicianCreator(new SingerCreator());
        band.RegisterMusicianCreator(new TrianglistCreator());

        // fill the band
        band.Fill(10);

        // let the band make some noise
        band.MakeNoise();

        int totalCost = band.ComputeCost(6);
        Console.WriteLine("Total cost = " + totalCost);
    }
}
