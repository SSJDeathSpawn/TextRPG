using System;

namespace TextRPG.Location {
    public class Connection {
        public Place north, east, south, west;
        public Place ne, nw, se, sw;
        public Place outside;

        public Connection(Place north, Place east, Place south, Place west, Place outside) {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
            this.outside = outside;
        }

        public Connection(Place north, Place east, Place south, Place west, Place outside, Place ne, Place nw, Place se, Place sw) {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
            this.outside = outside;
            this.ne = ne;
            this.nw = nw;
            this.se = se;
            this.sw = sw;
        }

        public Connection(Place outside) {
            this.outside = outside;
        }
    }
}