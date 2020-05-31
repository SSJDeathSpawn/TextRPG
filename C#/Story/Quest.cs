using TextRPG.Living;
using TextRPG.Data.Registry;

namespace TextRPG.Story {
    public abstract class Quest: IRegistryItem {
        public Character npc { get; set; }
        public QuestImportance importance { get; set; }
        public QuestType type { get; set; }

        public Quest(Character npc, QuestImportance importance, QuestType type) {
            this.npc = npc;
            this.importance = importance;
        }

        public void register() {
            
        }
    }

    public enum QuestType {
        KILL,
        DELIVERY,
        ESCORT,
        GATHER,
        HYBRID,
    }

    public enum QuestImportance {
        SIDE,
        MAIN,
    }
}