using System;

public class MusicianCreator<T> : MusicianCreatorBase where T : Musician, new()
{
    public override Musician CreateMusician()
    {
        return new T();
    }
}
