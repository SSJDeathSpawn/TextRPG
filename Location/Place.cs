using System;
using System.Collections.Generic;

namespace TextRPG.Location {
    public class Place {
        public string name;
        public List<Place> contains;
        public Place(String name, List<Place> contains) {
            this.name = name;
            this.contains = contains;
        }

        public Place(String name) {
            this.name = name;
            this.contains = new List<Place>(); 
        }   
    }
}