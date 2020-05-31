using System;

namespace TextRPG.Objects {
    public class ItemInstance {
        public Item item { get; set; }
        public int amount { get; set; }

        public ItemInstance(Item item, int amount){
            this.item = item;
            this.amount = (amount < item.stackSize)? amount: item.stackSize;
        }

    }
}