using System;
using TextRPG.Living;
using TextRPG.Data.Registry;

namespace TextRPG.Objects {
    public abstract class Interactable: IRegistryItem {
        public string name { get; set; }
        public string desc { get; set; }
        public Action<CharacterUpgraded> onUse { get; set; }

        public Interactable(string name, string desc, Action<CharacterUpgraded> onUse) {
            this.name = name;
            this.desc = desc;
            this.onUse = onUse;
        }

        public virtual void register() {

        }
    }
}