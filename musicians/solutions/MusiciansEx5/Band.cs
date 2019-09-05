using System;
using System.Collections.Generic;

public class Band
{
    protected List<Musician> musicians;

    // a list of creator objects
    protected List<MusicianCreator> musicianCreators;

    // used for generating random musicians
    protected Random random;

    public Band()
    {
        this.random = new Random();
        this.musicians = new List<Musician>();
        this.musicianCreators = new List<MusicianCreator>();
    }

    public void Fill(int nrMembers)
    {
        for (int i = 0; i < nrMembers; i += 1)
        {
            this.musicians.Add(this.RandomMusician());
        }
    }

    public void RegisterMusicianCreator(MusicianCreator creator)
    {
        this.musicianCreators.Add(creator);
    }

    // this method creates a random musician by using the creator objects
    private Musician RandomMusician()
    {
        int randomNr = this.random.Next(0, this.musicianCreators.Count);
        return this.musicianCreators[randomNr].CreateMusician();
    }

    public void MakeNoise()
    {
        foreach (Musician musician in this.musicians)
        {
            musician.MakeNoise();
        }
    }

    public virtual int ComputeCost(int nrHours)
    {
        int totalCost = 0;
        foreach (Musician musician in this.musicians)
        {
            totalCost += musician.ComputeCost(nrHours);
        }
        return totalCost;
    }
}

