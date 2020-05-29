using TextRPG.Living;

namespace TextRPG.Story.Quests {
    public class KillQuest: Quest {
        public Character toKill;
        public int times;

        public KillQuest(Character npc, Character toKill, int times, QuestImportance importance): base(npc, importance, QuestType.KILL) {
            this.toKill = toKill;
            this.times = times;
        }

        
    }
}