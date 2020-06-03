using System;

namespace TextRPG.Data.Moves.Elemental {
    public class Element{

        public string name { get; set; }
        public Element weakness { get; set; }

        public Element(string name) {
            this.name = name;
        }
    }
}