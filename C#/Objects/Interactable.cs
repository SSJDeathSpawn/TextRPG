using System;
using TextRPG.Living;

namespace TextRPG.Objects {
    public abstract class Interactable{
        public string name { get; set; }
        public string desc { get; set; }
        public Action<CharacterUpgraded> onUse { get; set; }

        public Interactable(string name, string desc, Action<CharacterUpgraded> onUse) {
            this.name = name;
            this.desc = desc;
            this.onUse = onUse;
        }
    }
}