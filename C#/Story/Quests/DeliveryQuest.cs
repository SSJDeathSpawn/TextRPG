using TextRPG.Living;
using TextRPG.Objects;

namespace TextRPG.Story.Quests {
    public class DeliveryQuest: Quest {
        Character toWhom { get; set; }
        ItemInstance what { get; set; }

        public DeliveryQuest(Character npc, Character toWhom, ItemInstance what, QuestImportance importance): base(npc, importance, QuestType.DELIVERY) {
            this.toWhom = toWhom;
            this.what = what;
        }
    }
}