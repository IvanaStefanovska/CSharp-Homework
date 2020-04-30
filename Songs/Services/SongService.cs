using System;

namespace Services
{
    public class SongService
    {

        public SongModel FindByName(SongModel[] songs, string name)
        {
            foreach (SongModel song in songs)
            {
                if (song.Name == name)
                    return song;
            }

            return null;
        }

        public void FindByAuthor(SongModel[] songs, string author)
        {
            foreach (SongModel song in songs)
            {
                if (song.Author == author)
                    Console.WriteLine($"{song.Name} Found");
            }
        }

        public void FindByGenre(SongModel[] songs, Genre genre)
        {
            foreach (SongModel song in songs)
            {
                if (song.Genre == genre)
                    Console.WriteLine($"{song.Name} Found");
            }
        }

        public SongModel[] AddSong(SongModel[] songs, SongModel song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
            return songs;
        }

        public SongModel[] FindSongLongerThan(SongModel[] songs, int seconds)
        {
            SongModel[] resultSongs = new SongModel[0];

            foreach (SongModel song in songs)
            {
                if (songs.Length > seconds)
                    resultSong
            }
        }
    }
}
