using System;
using TextRPG.Living;

namespace TextRPG.Objects {
    public abstract class Interactable {
        public string name;

        public Interactable(string name) {
            this.name = name;
        }

        public abstract void onUse(Character chara);
    }
}