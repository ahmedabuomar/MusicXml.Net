using System;

namespace MusicXml.Domain
{
    public class Barline
    {
        internal Barline()
        {
            location = string.Empty;
            direction = string.Empty;
            endingNumber = -1;
            endingType = string.Empty;
        }
        
        public string location { get; internal set; }
        public string direction { get; internal set; }
        public int endingNumber { get; internal set; }
        public string endingType { get; internal set; }
    }
}
