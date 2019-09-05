public class Band
{
    protected Drummer drummer;
    protected BassPlayer bassPlayer;
    protected Singer singer;

    public Band()
    {
        this.drummer = new Drummer();
        this.bassPlayer = new BassPlayer();
        this.singer = new Singer();
    }

    public void MakeNoise()
    {
        this.drummer.MakeNoise();
        this.bassPlayer.MakeNoise();
        this.singer.MakeNoise();
    }
}

