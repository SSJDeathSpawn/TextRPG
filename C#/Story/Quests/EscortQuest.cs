using TextRPG.Living;
using TextRPG.Location;
using System;

namespace TextRPG.Story.Quests {
    public class EscortQuest: Quest {
        CharacterUpgraded toEscort { get; set; }
        Place toWhere { get; set; }

        public EscortQuest(Character npc, CharacterUpgraded toEscort, Place toWhere, QuestImportance importance): base(npc, importance, QuestType.ESCORT) {
            this.toEscort = toEscort;
            this.toWhere = toWhere;
        }

         public override T returnFlowStuff<T>() where T: class {
            if(base.returnFlowStuff<T>() == null) {
                if(toWhere is T) {
                    return (T)Convert.ChangeType(toWhere, typeof(T));
                } if(toEscort is T) {
                    return (T)Convert.ChangeType(toEscort, typeof(T));
                }
            }
            return (T)null;
        }
    }
}