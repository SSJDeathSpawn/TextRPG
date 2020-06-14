using TextRPG.Living;
using System;

namespace TextRPG.Story.Objectives {
    public class TalkObjective:Objective {
        Character toWhom;

        public TalkObjective(Character toWhom): base(ObjectiveType.TALK) {
            this.toWhom = toWhom;
        }

        public override T returnFlowStuff<T>() where T: class {
            if (base.returnFlowStuff<T>() == null) {
                if(toWhom is T) {
                    return (T)Convert.ChangeType(toWhom, typeof(T));
                }
            }
            return (T)null;
        }
    }
}