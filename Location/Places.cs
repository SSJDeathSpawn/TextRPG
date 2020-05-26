using System;
using System.Collections.Generic;
using TextRPG.Living;
using TextRPG.Data;

namespace TextRPG.Location{
    public class Places{
        public static Dungeon starterDungeon = new Dungeon("Starter Dungeon", 1, Program.enemyData.starterDungeon);

        public static Place yourPlace = new Place("Your Room", new Connection(arrowhorneResidentialDistrict));
        public static Place arrowhorneResidentialDistrict = new Place("Arrow Horn, Residential Area");
        public static Place arrowhornMainStreet = new Place("Arrow Horn, Main Street", new Connection(null, arrowhornAdventrureGuild, null, arrowhorneResidentialDistrict, null));
        public static Place arrowhornAdventrureGuild = new Place("Arrow Horn, Adventure Guild", new Connection(arrowhornMainStreet));
    }
}