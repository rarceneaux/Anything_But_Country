using System;
using System.Collections.Generic;
using System.Text;

namespace AnythingButCountry
{
    public class Song
    {
        public  string Artist { get; set; }
        public  string Name { get; set; }

        public Song(string artist, string name)
        {
            this.Artist = artist;
            this.Name = name;


             var goodSongs = new List<string>(){};

            var allSongs = new List<string>() {"Gorilla Pimp","Chicken Head" };
            allSongs.Add("Sippin on Syrup");

        }
    }
}
