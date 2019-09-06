using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // create a band
        Band band = new Band();

        // register the creators
        band.RegisterMusicianCreator(new MusicianCreator<Drummer>());
        band.RegisterMusicianCreator(new MusicianCreator<BassPlayer>());
        band.RegisterMusicianCreator(new MusicianCreator<Singer>());
        band.RegisterMusicianCreator(new MusicianCreator<Trianglist>());

        // fill the band
        band.Fill(5);

        // let the band make some noise
        band.MakeNoise();

        int totalCost = band.ComputeCost(6);
        Console.WriteLine("Total cost = " + totalCost);
    }
}
