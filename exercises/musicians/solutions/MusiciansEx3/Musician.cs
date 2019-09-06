using System;

public abstract class Musician
{
    protected int hourRate = 0;
    protected int fixedRate = 0;

    public virtual int ComputeCost(int nrHours)
    {
        return this.fixedRate + this.hourRate * nrHours;
    }

    public abstract void MakeNoise();

}

