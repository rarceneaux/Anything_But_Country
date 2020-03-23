using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

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


             /*var goodSongs = new List<string>(){};*/
             var allSongs = new List<KeyValuePair<string,string>>();
             allSongs.Add(new KeyValuePair<string, string>("Project Pat","Keep it Hood"));
             allSongs.Add(new KeyValuePair<string, string>("Juicy J","Hustle Til I Die"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Gorilla Pimp"));
             allSongs.Add(new KeyValuePair<string, string>("Kevin Gates", "MATA"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Don't save her"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Chicken Head"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Ski Mask"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "North North"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Aggravated Robbery"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "If you ain't from my hood"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "I Ain't going back to jail"));
             allSongs.Add(new KeyValuePair<string, string>("Project Pat", "Sippin on some sizzurp"));
        }
    }
}
