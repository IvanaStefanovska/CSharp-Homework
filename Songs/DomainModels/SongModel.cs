using System;
using Services;

namespace DomainModels
{
    public class SongModel
    {

        public SongModel()
        {
            Name = "Bohemian Rapsody";
            Band = "Queen";
            Genre = Genre.Rock;
            Language = "english";
            Length = 180;
            Author = "Bryan";
        }
        public SongModel(string name, string band, Genre genre, string language, int length, string author)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Language = language;
            Band = band;
            Length = length;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public int Length { get; set; }
        public string Band { get; set; }

    }
}
