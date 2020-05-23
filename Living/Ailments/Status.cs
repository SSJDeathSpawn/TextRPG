using System;
using System.Collections.Generic;

namespace TextRPG.Living.Ailments {
    public class Status {
        public StatusType statusType;
        public string name;
        //public delegate void Worker(Character chara, int modifier);
        //TODO Research Func and add it 
        public Status(string name, StatusType statusType /*,doWork*/) {
            this.name = name;
            this.statusType = statusType;
            //Worker dowork = new Worker(doWork);
        }
    }

    public enum StatusType {
        GOOD,
        BAD
    }
}