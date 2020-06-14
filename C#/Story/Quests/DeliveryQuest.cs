using TextRPG.Living;
using TextRPG.Objects;
using System;

namespace TextRPG.Story.Quests {
    public class DeliveryQuest: Quest {
        Character toWhom { get; set; }
        ItemInstance what { get; set; }

        public DeliveryQuest(Character npc, Character toWhom, ItemInstance what, QuestImportance importance): base(npc, importance, QuestType.DELIVERY) {
            this.toWhom = toWhom;
            this.what = what;
        }

        public override T returnFlowStuff<T>() where T: class {
            if(base.returnFlowStuff<T>() == null) {
                if(what is T) {
                    return (T)Convert.ChangeType(what, typeof(T));
                }
            }
            return (T)null;
        }

        public override T returnFlowStuff<T>(int i) where T: class {
            if(base.returnFlowStuff<T>() == null) {
                if(toWhom is T && i == 2) {
                    return (T)Convert.ChangeType(toWhom, typeof(T));
                }
            }
            return (T)null;
        }
    }
}