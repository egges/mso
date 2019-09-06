using System;

public class Trianglist : Musician
{
    public Trianglist()
    {
        this.hourRate = 500;
        this.fixedRate = 1000;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Ting...");
    }
}

