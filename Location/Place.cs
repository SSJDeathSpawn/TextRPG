using System;
using System.Collections.Generic;

namespace TextRPG.Location {
    public class Place {
        public string name;
        public Place locatedIn;
        public List<Place> contains;
    }
}