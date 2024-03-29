﻿namespace ALXCourseHomework.Classes
{
    internal class TrackReservation
    {
        public Tracks Track { get; private set; }
        public int NoOfHouersTrack { get; private set; }
        public TrackReservation(Tracks track, int noofhouerstrack)
        {
            Track = track;
            NoOfHouersTrack = noofhouerstrack;
        }
        public decimal GetPriceT()
        {
            return Track.PriceOfTrack * NoOfHouersTrack;
        }
    }
}

