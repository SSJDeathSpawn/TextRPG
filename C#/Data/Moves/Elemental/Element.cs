using System;
using TextRPG.Data.Registry;

namespace TextRPG.Data.Moves.Elemental {
    public class Element: IRegistryItem{

        public string name { get; set; }
        public Element weakness { get; set; }

        public Element(string name) {
            this.name = name;
        }

        public void register() {

        }
    }
}