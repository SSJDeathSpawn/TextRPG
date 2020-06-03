using System;
using TextRPG.Living;

namespace TextRPG.Objects {
    public class Item: Interactable{
        public int stackSize { get; set; }
        public bool oneUse { get; set; }
        public int timesUsable { get; set; }
        public ItemRarity itemRarity { get; set; }

        public Item(string name, int stackSize, ItemRarity itemRarity, Action<CharacterUpgraded> onUse, string desc): base(name, desc, onUse) {
            this.stackSize = stackSize;
            this.oneUse = true;
            this.timesUsable = 1;
            this.itemRarity = itemRarity;
        }

        public Item(string name, int stackSize, int timesUsable, ItemRarity itemRarity, Action<CharacterUpgraded> onUse, string desc): base(name, desc, onUse) {
            this.stackSize = stackSize;
            this.oneUse = false;
            this.timesUsable = timesUsable;
            this.itemRarity = itemRarity;
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