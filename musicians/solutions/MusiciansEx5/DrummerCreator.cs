public class DrummerCreator : MusicianCreator
{
    public override Musician CreateMusician()
    {
        return new Drummer();
    }
}

