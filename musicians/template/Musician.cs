using System;

public abstract class Musician
{
    // by default, musicians do not get paid anything
    // (apart from exposure bucks of course)
    protected int hourRate = 0;

    public virtual int ComputeCost(int nrHours)
    {
        return this.hourRate * nrHours;
    }

    public abstract void MakeNoise();

}

