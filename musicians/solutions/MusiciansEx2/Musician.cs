using System;

public abstract class Musician
{
    protected int hourRate = 0;

    // I opted to add a fixed rate here, since it's possible that
    // musicians other than the drummer also have a fixed rate
    protected int fixedRate = 0;

    public virtual int ComputeCost(int nrHours)
    {
        // we add the fixed rate in the computation here
        return this.fixedRate + this.hourRate * nrHours;
    }

    public abstract void MakeNoise();

}

