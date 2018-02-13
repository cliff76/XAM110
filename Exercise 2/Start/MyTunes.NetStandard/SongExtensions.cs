using System;
//using System.Net.Http;

namespace MyTunes
{
    public static class SongExtensions
    {
        //static HttpClient httpClient = new HttpClient();

        public static string RuinSongName(this string songname) {
            return songname.Replace("Crocodile", "Alligator").Replace("You", "Me").Replace("the", "our").Replace("The", "Your");
        }
    }
}
