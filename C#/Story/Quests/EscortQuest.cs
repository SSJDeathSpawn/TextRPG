using TextRPG.Living;
using TextRPG.Location;

namespace TextRPG.Story.Quests {
    public class EscortQuest: Quest {
        Character toEscort { get; set; }
        Place toWhere { get; set; }

        public EscortQuest(Character npc, Character toEscort, Place toWhere, QuestImportance importance): base(npc, importance, QuestType.ESCORT) {
            this.toEscort = toEscort;
            this.toWhere = toWhere;
        }
    }
}