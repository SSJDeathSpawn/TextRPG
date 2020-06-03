using System;
using System.Collections.Generic;

namespace TextRPG.Data {
    public class Race{
        public string name { get; set; }
        public string desc { get; set; }

        public Race(string name, string desc) {
            this.name = name;
            this.desc = desc;
        }
    }
}