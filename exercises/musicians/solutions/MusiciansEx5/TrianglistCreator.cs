public class TrianglistCreator : MusicianCreator
{
    public override Musician CreateMusician()
    {
        return new Trianglist();
    }
}
