using System;
using System.Collections.Generic;
using TextRPG.Data.Registry;

namespace TextRPG.Data {
    public class Race: IRegistryItem{
        public string name { get; set; }
        public string desc { get; set; }

        public void register() {
            
        }
    }
}