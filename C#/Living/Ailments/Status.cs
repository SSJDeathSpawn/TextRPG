using System;
using System.Collections.Generic;
using TextRPG.Data.Registry;

namespace TextRPG.Living.Ailments {
    public class Status: IRegistryItem {
        public StatusType statusType { get; set; }
        public string name { get; set; }
        public Action<Character,int> doWork { get; set; }
        
        public Status(string name, StatusType statusType, Action<Character, int> doWork) {
            this.name = name;
            this.statusType = statusType;
            this.doWork = doWork;
        }

        public void register() {

        }
    }

    public enum StatusType {
        GOOD,
        BAD
    }
}