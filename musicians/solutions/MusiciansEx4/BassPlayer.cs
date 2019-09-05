using System;

public class BassPlayer : Musician
{
    public BassPlayer()
    {
        this.hourRate = 50;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Dum dum dum");
    }
}

