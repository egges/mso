public class SingerCreator : MusicianCreator
{
    public override Musician CreateMusician()
    {
        return new Singer();
    }
}
