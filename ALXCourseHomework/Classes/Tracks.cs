using System;
namespace ALXCourseHomework.Classes
{
    public class Tracks
    {
        public string Track { get; private set; }
        public decimal PriceOfTrack { get; private set; }
        public Tracks(string track, decimal priceoftrack)
        {
            Track = track;
            PriceOfTrack = priceoftrack;
        }
    }

}
