public class Band
{
    protected Drummer drummer;
    protected BassPlayer bassPlayer;
    protected Singer singer;
    protected Trianglist trianglist;

    public Band()
    {
        this.drummer = new Drummer();
        this.bassPlayer = new BassPlayer();
        this.singer = new Singer();
        this.trianglist = new Trianglist();
    }

    public void MakeNoise()
    {
        this.drummer.MakeNoise();
        this.bassPlayer.MakeNoise();
        this.singer.MakeNoise();
        this.trianglist.MakeNoise();
    }

    public virtual int ComputeCost(int nrHours)
    {
        int totalCost = 0;
        totalCost += this.drummer.ComputeCost(nrHours);
        totalCost += this.bassPlayer.ComputeCost(nrHours);
        totalCost += this.singer.ComputeCost(nrHours);
        totalCost += this.trianglist.ComputeCost(nrHours);
        return totalCost;
    }
}

