using System;

public abstract class Musician
{
    protected int hourRate = 0;

    public virtual int ComputeCost(int nrHours)
    {
        return this.hourRate * nrHours;
    }

    public abstract void MakeNoise();

}

