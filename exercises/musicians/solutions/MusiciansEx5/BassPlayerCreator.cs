public class BassPlayerCreator : MusicianCreator
{
    public override Musician CreateMusician()
    {
        return new BassPlayer();
    }
}
