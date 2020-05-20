using System;
using System.Collections.Generic;
using TextRPG.Data;

namespace TextRPG.Living {
    public class Mob: Character{
        public (int, int) lvlRange;
        public string desc;

        public static Race monster = new Race();

        public Mob(string name, int a, int b, string desc, Stats stats): base(name, monster, stats) {
            this.lvlRange = (a,b);
            this.desc = desc;
        }
    }
}