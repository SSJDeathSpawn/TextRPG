using TextRPG.Living;
using System;

namespace TextRPG.Story.Quests {
    public class KillQuest: Quest {
        public CharacterUpgraded toKill { get; set; }
        public int times { get; set; }

        public KillQuest(Character npc, CharacterUpgraded toKill, int times, QuestImportance importance): base(npc, importance, QuestType.KILL) {
            this.toKill = toKill;
            this.times = times;
        }

         public override T returnFlowStuff<T>() where T: class {
            if(base.returnFlowStuff<T>() == null) {
                if(times is T) {
                    return (T)Convert.ChangeType(times, typeof(T));
                } if (toKill is T) {
                    return (T)Convert.ChangeType(toKill, typeof(T));
                }
            }
            return (T)null;
        }

        
    }
}