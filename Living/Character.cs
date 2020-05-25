using System;
using System.Collections.Generic;
using TextRPG.Data;
using TextRPG.Data.Statistics;
using TextRPG.Location;
using TextRPG.Data.Registry;

namespace TextRPG.Living {

    public class Character: IRegistryItem {
        public string name;
        public Race race;
        public Stats stats;
        public Place currentLocation;

        public Character(string name, Race race, Stats stats) {
            this.name = name;
            this.race = race;
            this.stats = stats;
        }

        public virtual void register() {

        }

    }

}