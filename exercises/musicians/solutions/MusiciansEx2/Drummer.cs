using System;

public class Drummer: Musician
{
    public Drummer()
    {
        this.hourRate = 100;
        // the line below is the only thing we need to change
        // in the Drummer class
        this.fixedRate = 200;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Boom tjsk tjsk tjsk");
    }
}

