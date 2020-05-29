using System;
using TextRPG.Data.Registry;
using TextRPG.Living;

namespace TextRPG.Objects {
    public class Item: Interactable{
        public int stackSize;
        public bool oneUse;
        public int timesUsable;
        public ItemRarity itemRarity; 

        public Item(string name, int stackSize, ItemRarity itemRarity, Action<Character> onUse, string desc): base(name, desc, onUse) {
            this.stackSize = stackSize;
            this.oneUse = true;
            this.timesUsable = 1;
            this.itemRarity = itemRarity;
        }

        public Item(string name, int stackSize, int timesUsable, ItemRarity itemRarity, Action<Character> onUse, string desc): base(name, desc, onUse) {
            this.stackSize = stackSize;
            this.oneUse = false;
            this.timesUsable = timesUsable;
            this.itemRarity = itemRarity;
        }

        public override void register() {
            base.register();
        }

    }

    public enum ItemRarity {
        NORMAL,
        UNCOMMON,
        EPIC,
        LEGENDARY,
        KEY
    }
}