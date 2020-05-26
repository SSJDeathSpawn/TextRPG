using System;
using System.Collections.Generic;
using TextRPG.Data.Registry;

namespace TextRPG.Location {
    public class Place: IRegistryItem {
        public string name;
        public Connection connection;
        public string desc;
        
        public Place(String name, Connection connection) {
            this.name = name;
            this.connection = connection;;
        }

        public Place(String name) {
            this.name = name;
            this.connection = new Connection(null); 
        }   

        public virtual void register() {

        }
    }
}