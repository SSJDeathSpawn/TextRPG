using System;
using TextRPG.Story.Control;

namespace TextRPG.Story {
    public class Objective: Flowable {
        ObjectiveType type;

        public Objective(ObjectiveType type) {
            this.type = type;
        }

        public virtual T returnFlowStuff<T>() where T: class {
            if(type is T) {
                return (T)Convert.ChangeType(type, typeof(T));
            }
            return (T)null;
        }   
    }
    public enum ObjectiveType {
        PLACE,
        TALK,
        PICKUP
    }

}