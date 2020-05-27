using System;
using TextRPG.Data.Registry;
using TextRPG.Living;

namespace TextRPG.Objects {
    public class Item: IRegistryItem{
        public string name;
        public int stackSize;
        public bool oneUse;
        public ItemRarity itemRarity;
        public Action<Character> onUse; 

        public Item(string name, int stackSize, bool oneUse, ItemRarity itemRarity, Action<Character> onUse) {
            this.name = name;
            this.stackSize = stackSize;
            this.oneUse = oneUse;
            this.itemRarity = itemRarity;
            this.onUse = onUse;
        }

        public void register() {

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