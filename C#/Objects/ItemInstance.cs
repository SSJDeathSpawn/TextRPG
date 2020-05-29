using System;

namespace TextRPG.Objects {
    public class ItemInstance {
        public Item item;
        public int amount;

        public ItemInstance(Item item, int amount){
            this.item = item;
            this.amount = (amount < item.stackSize)? amount: item.stackSize;
        }

    }
}