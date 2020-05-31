using TextRPG.Data;
using TextRPG.Data.Statistics;
using TextRPG.Location;

namespace TextRPG.Living {
    public class CharacterUpgraded: Character {
        
        public AttackStats stats { get; set; }

        public CharacterUpgraded(string name, Race race, AttackStats stats) : base(name, race){
            this.stats = stats;
        }
    }
}