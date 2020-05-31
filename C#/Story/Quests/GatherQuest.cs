using TextRPG.Objects;
using TextRPG.Living;

namespace TextRPG.Story.Quests {
    public class GatherQuest: Quest {
        Item toGather { get; set; }
        int times { get; set; }

        public GatherQuest(Character npc, Item toGather, int times, QuestImportance importance): base(npc, importance, QuestType.GATHER) {
            this.toGather = toGather;
            this.times  = times;
        }
    }
}