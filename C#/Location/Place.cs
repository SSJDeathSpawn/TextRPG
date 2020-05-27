using System;
using System.Collections.Generic;
using TextRPG.Data.Registry;

namespace TextRPG.Location {
    public class Place: IRegistryItem {
        public string name;
        public Connection connection;
        public string desc;
        
        public Place(String name, Connection connection, string desc) {
            this.name = name;
            this.connection = connection;
            this.desc = desc;
        }

        public Place(String name, string desc) {
            this.name = name;
            this.connection = new Connection(null);
            this.desc = desc; 
        }   

        public virtual void register() {

        }
    }
}