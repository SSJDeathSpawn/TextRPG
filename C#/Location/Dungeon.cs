using System;
using System.Collections.Generic;
using TextRPG.Living;

namespace TextRPG.Location {
    public class Dungeon: Place {
        public int recommededLvl;
        public Dictionary<Mob, float> enemiesWithChance;

        public Dungeon(string name, int recommededLvl, Dictionary<Mob, float> enemiesWithChance, string desc): base(name, desc) {
            this.recommededLvl = recommededLvl;
            this.enemiesWithChance = enemiesWithChance;
        }

        public void fixProbabilities() {
            enemiesWithChance.TrimExcess();
            float totalChance = 0.0F;
            foreach(float item in enemiesWithChance.Values) {
                totalChance += item;
            }
            if(totalChance != 1.0F) {
                float toMultiply;
                toMultiply = totalChance/1.0F;
                foreach(Mob mob in enemiesWithChance.Keys) {
                    enemiesWithChance[mob] *= toMultiply;
                }
            }
        }

        public List<Mob> returnRandomMobs(int number) {
            List<Mob> toReturn = new List<Mob>();
            Random random = new Random();
            for (int i=0; i<number;i++) {
                float a = (float)random.NextDouble();
                foreach (KeyValuePair<Mob, float> enemy in enemiesWithChance)
                {
                    a -= enemy.Value;
                    if(a<=0) {
                        toReturn.Add(enemy.Key);
                        break;
                    }
                }
            } 
            return toReturn;
        }

        public override void register() {
            base.register();
        }

    }
}