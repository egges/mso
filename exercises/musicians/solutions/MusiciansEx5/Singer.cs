using System;

public class Singer : Musician
{
    public Singer()
    {
        this.hourRate = 80;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Do re mi fa sol la ti do!");
    }
}

