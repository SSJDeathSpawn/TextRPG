using System;
using System.Collections.Generic;

namespace TextRPG.Data {
    public abstract class BaseStats {
        public int str;
        public int dex;
        public int wis;
        public int chr;
        public int con;
        public int wil;

        public abstract void onStatChange(BaseStats newStats);
    }
}