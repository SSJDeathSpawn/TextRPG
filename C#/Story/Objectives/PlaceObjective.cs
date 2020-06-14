using TextRPG.Location;
using System;

namespace TextRPG.Story.Objectives {
    public class PlaceObjective: Objective {
        Place toWhere;

        public PlaceObjective(Place toWhere): base(ObjectiveType.PLACE) {
            this.toWhere = toWhere;
        }

        public override T returnFlowStuff<T>() where T: class {
            if (base.returnFlowStuff<T>() == null) {
                if(toWhere is T) {
                    return (T)Convert.ChangeType(toWhere, typeof(T));
                }
            }
            return (T)null;
        }
    }
}