using System;
using DomainModels;
using Services;


namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            SongModel song1 = new SongModel();
            SongModel song2 = new SongModel();
            SongModel song3 = new SongModel();
            SongModel song4 = new SongModel();
            SongModel[] songs = new SongModel[] { song1, song2, song3, song4};

            Console.ReadLine();
        }
    }
}
