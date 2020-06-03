using System;
using System.Collections.Generic;
using TextRPG.Data;
using TextRPG.Data.Statistics;
using TextRPG.Location;

namespace TextRPG.Living {

    public class Character {
        public string name { get; set; }
        public Race race { get; set; }
        public Place currentLocation { get; set; }

        public Character(string name, Race race) {
            this.name = name;
            this.race = race;
        }

        public virtual void register() {

        }

    }

}