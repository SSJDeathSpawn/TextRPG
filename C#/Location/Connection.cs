using System;
using System.Collections.Generic;

namespace TextRPG.Location {
    public class Connection {
        public Place north { get; set; }
        public Place east { get; set; }
        public Place south { get; set; }
        public Place west { get; set; }
        public Place ne { get; set; }
        public Place nw { get; set; }
        public Place se { get; set; }
        public Place sw { get; set; }
        public Place outside { get; set; }

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
                if (toReturn.north==null) toReturn.north = (conn.North == p.name)?p:null;
                if (toReturn.south==null)toReturn.south = (conn.South == p.name)?p:null;
                if (toReturn.east==null)toReturn.east = (conn.East == p.name)?p:null;
                if (toReturn.west==null)toReturn.west = (conn.West == p.name)?p:null;
                if (toReturn.outside==null)toReturn.outside = (conn.Outside == p.name)?p:null;
                if (toReturn.ne==null)toReturn.ne = (conn.ne == p.name)?p:null;
                if (toReturn.nw==null)toReturn.nw = (conn.nw == p.name)?p:null;
                if (toReturn.se==null)toReturn.se = (conn.se == p.name)?p:null;
                if (toReturn.sw==null)toReturn.sw = (conn.sw == p.name)?p:null;
            }
            return toReturn;
        }
    }
}