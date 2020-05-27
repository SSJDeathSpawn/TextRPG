using System;
using System.Collections.Generic;
using TextRPG.Data.Statistics;
using TextRPG.Data.Registry;

namespace TextRPG.Living {
    public class Species: IRegistryItem {
        public string commonName;
        public List<string> extendedNames;
        public List<Mob> madeMobs = new List<Mob>();

        public Species(string commonName, List<string> extendedNames, List<Stats> stats, List<(int,int)> lvlRanges, List<string> descs) {
            this.commonName = commonName;
            this.extendedNames = extendedNames;

            for(int i=0; i < stats.Count;i++) {
                madeMobs.Add(new Mob(this.extendedNames[i] + this.commonName[i], lvlRanges[i].Item1, lvlRanges[i].Item2, descs[i], stats[i]));
            }
        }

        public void register() {
            foreach(Mob mob in madeMobs) {
                mob.register();
            }
        }
    }
}