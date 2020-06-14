using TextRPG.Objects;
using TextRPG.Living;
using System;

namespace TextRPG.Story.Quests {
    public class GatherQuest: Quest {
        Item toGather { get; set; }
        int times { get; set; }

        public GatherQuest(Character npc, Item toGather, int times, QuestImportance importance): base(npc, importance, QuestType.GATHER) {
            this.toGather = toGather;
            this.times  = times;
        }

         public override T returnFlowStuff<T>() where T: class {
            if(base.returnFlowStuff<T>() == null) {
                if(toGather is T) {
                    return (T)Convert.ChangeType(toGather, typeof(T));
                } if(times is T) {
                    return (T)Convert.ChangeType(times, typeof(T));
                }
            }
            return (T)null;
        }
    }
}