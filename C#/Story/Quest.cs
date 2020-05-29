using TextRPG.Living;
using TextRPG.Data.Registry;

namespace TextRPG.Story {
    public class Quest: IRegistryItem {
        public Character npc;
        public QuestImportance importance;
        public QuestType type;

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