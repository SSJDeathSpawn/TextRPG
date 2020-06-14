using TextRPG.Living;
using TextRPG.Story.Control;
using System;

namespace TextRPG.Story {
    public abstract class Quest: Flowable {
        public Character npc { get; set; }
        public QuestImportance importance { get; set; }
        public QuestType type { get; set; }

        public Quest(Character npc, QuestImportance importance, QuestType type) {
            this.npc = npc;
            this.importance = importance;
        }

        public virtual T returnFlowStuff<T>() where T: class {
            if(type is T) {
                return (T)Convert.ChangeType(type, typeof(T));
            } if(importance is T) {
                return (T)Convert.ChangeType(importance, typeof(T));
            } if(npc is T) {
                return (T)Convert.ChangeType(npc, typeof(T));
            }
            return (T)null;
        }

        public virtual T returnFlowStuff<T>(int i) where T: class {
            if(npc is T && i == 1) {
                return (T)Convert.ChangeType(npc, typeof(T));
            }
            return (T)null;
        }
    }

    public enum QuestType {
        KILL,
        DELIVERY,
        ESCORT,
        GATHER,
    }

    public enum QuestImportance {
        SIDE,
        MAIN,
    }
}