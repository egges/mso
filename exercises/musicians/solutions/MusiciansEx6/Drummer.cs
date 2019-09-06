using System;

public class Drummer: Musician
{
    public Drummer()
    {
        this.hourRate = 100;
        // this is the only thing we need to change
        // for this exercise
        this.fixedRate = 200;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Boom tjsk tjsk tjsk");
    }
}

