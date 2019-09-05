using System;

public class Band
{
    // we now store musicians in an array
    protected Musician[] musicians;

    // used for generating random musicians
    protected Random random;

    public Band(int nrMembers)
    {
        this.random = new Random();
        this.musicians = new Musician[nrMembers];
        for (int i = 0; i < nrMembers; i += 1)
        {
            this.musicians[i] = this.RandomMusician();
        }
    }

    // this method creates a random musician
    // and as a result, we can generalize the other methods
    // in this class so they don't need to know anything anymore
    // about specific musician types
    private Musician RandomMusician()
    {
        int randomNr = this.random.Next(0, 4);
        switch (randomNr)
        {
            case 0: return new Drummer();
            case 1: return new BassPlayer();
            case 2: return new Singer();
            default: return new Trianglist();
        }
    }

    // the two methods below are now generic - they do not need to know
    // anything about specific musicians

    public void MakeNoise()
    {
        for (int i = 0; i < this.musicians.Length; i += 1)
        {
            this.musicians[i].MakeNoise();
        }
    }

    public virtual int ComputeCost(int nrHours)
    {
        int totalCost = 0;
        for (int i = 0; i < this.musicians.Length; i += 1)
        {
            totalCost += this.musicians[i].ComputeCost(nrHours);
        }
        return totalCost;
    }
}

