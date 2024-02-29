using System;
using System.Drawing;

class Song
{
    string _title;
    string _artist;
    int _duration;
    int _release;


    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length<0)
            {
                throw new ArgumentException("Title is empty");
            }
            _title = value;
        }
    }
    public string Artist
    {
        get { return _artist; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Name of artist is empty!");
            }
            _artist = value;
        }
    }

    public int Duration
    {
        get { return _duration; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("The duration cannot be less than 1 minute");
            }
            _duration = value;
        }
    }

    public int Release
    {
        get { return _release; }
        set
        {
            if ( value < 1996)
            {
                throw new ArgumentException("There were no players before 1996!");
            }
            _release = value;
        }
    }

    public Song()
    {
        Title = "Фотографирую закат";
        Artist = "Fem.love";
        Duration = 156;
        Release = 2020;
    }

    public Song(string title, string artist, int duration, int release)
    {
        Title= title;   
        Artist= artist;
        Duration = duration;
        Release = release;
    }
}
