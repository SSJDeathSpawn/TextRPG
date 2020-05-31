using System;
using System.Collections.Generic;

namespace TextRPG.Data.Registry
{
    public class Registry
    {
        public static List<IRegistryItem> registryItems { get; set; }
        
        public Registry() {
            registryItems = new List<IRegistryItem>();
        }

        public static void register(IRegistryItem item) {
            registryItems.Add(item);
        }

        public void registerItems() {
            foreach (IRegistryItem a in registryItems) {
                a.register();
            }
        }

    }
}