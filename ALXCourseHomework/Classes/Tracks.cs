using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
