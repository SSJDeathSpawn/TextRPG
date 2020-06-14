using TextRPG.Data;
using TextRPG.Data.Statistics;
using TextRPG.Location;

namespace TextRPG.Living {
    public class CharacterUpgraded: Character {
        
        public AttackStats stats { get; set; }

        public CharacterUpgraded(string name, Race race, Gender gender, AttackStats stats) : base(name, race, gender){
            this.stats = stats;
        }
    }
}