using System;
using System.Collections.Generic;
using TextRPG.Data.Statistics;

namespace TextRPG.Living {
    public class Species {
        public string commonName { get; set; }
        public List<string> extendedNames { get; set; }
        public List<Mob> madeMobs { get; set; } = new List<Mob>();

        public Species(string commonName, List<string> extendedNames, List<AttackStats> stats, List<(int,int)> lvlRanges, List<string> descs) {
            this.commonName = commonName;
            this.extendedNames = extendedNames;

            for(int i=0; i < stats.Count;i++) {
                madeMobs.Add(new Mob(this.extendedNames[i] + this.commonName[i], lvlRanges[i].Item1, lvlRanges[i].Item2, descs[i], stats[i]));
            }
        }
    }
}