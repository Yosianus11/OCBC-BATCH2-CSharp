using System;

namespace MovieApi.Models
{
    public class MovieData
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string GENRE { get; set;}
        public string DURATION { get; set; }
        public DateTime RELEASE_DATE { get; set; }
    }
}