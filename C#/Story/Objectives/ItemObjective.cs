using TextRPG.Objects;
using System;

namespace TextRPG.Story.Objectives {
    public class ItemObjective: Objective {
        ItemInstance toGet;

        public ItemObjective(ItemInstance toGet) : base(ObjectiveType.PICKUP) {
            this.toGet = toGet;
        }

        public override T returnFlowStuff<T>() where T: class {
            if (base.returnFlowStuff<T>() == null) {
                if(toGet is T) {
                    return (T)Convert.ChangeType(toGet, typeof(T));
                }
            }
            return (T)null;
        }
    }
}