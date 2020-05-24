using System;
using System.Collections.Generic;

namespace TextRPG.Living.Ailments {
    public class Status {
        public StatusType statusType;
        public string name;
        public Action<Character,int> doWork;
        
        public Status(string name, StatusType statusType Action<Character, int> doWork) {
            this.name = name;
            this.statusType = statusType;
            this.doWork = doWork;
        }
    }

    public enum StatusType {
        GOOD,
        BAD
    }
}