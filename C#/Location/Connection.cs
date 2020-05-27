using System;
using System.Collections.Generic;

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

        public static Connection convertToActual(TextRPG.Resources.Templates.Connection conn, List<Place> all) {

            Connection toReturn = new Connection(null);
            foreach(Place p in all) {
                if (toReturn.north==default(Place)) toReturn.north = (conn.North == p.name)?p:null;
                if (toReturn.south==default(Place))toReturn.south = (conn.South == p.name)?p:null;
                if (toReturn.east==default(Place))toReturn.east = (conn.East == p.name)?p:null;
                if (toReturn.west==default(Place))toReturn.west = (conn.West == p.name)?p:null;
                if (toReturn.outside==default(Place))toReturn.outside = (conn.Outside == p.name)?p:null;
                if (toReturn.ne==default(Place))toReturn.ne = (conn.ne == p.name)?p:null;
                if (toReturn.nw==default(Place))toReturn.nw = (conn.nw == p.name)?p:null;
                if (toReturn.se==default(Place))toReturn.se = (conn.se == p.name)?p:null;
                if (toReturn.sw==default(Place))toReturn.sw = (conn.sw == p.name)?p:null;
            }
            return toReturn;
        }
    }
}