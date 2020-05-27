using System;

namespace TextRPG.Objects {
    public class ItemInstance {
        public Item item;
        public int amount;

        public ItemInstance(Item item, int amount){
            this.item = item;
            if (amount < item.stackSize)
                this.amount = amount;
            else
                this.amount = item.stackSize;
        }

    }
}