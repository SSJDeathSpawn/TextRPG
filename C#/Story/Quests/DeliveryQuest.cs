using TextRPG.Living;
using TextRPG.Objects;

namespace TextRPG.Story.Quests {
    public class DeliveryQuest: Quest {
        Character toWhom;
        ItemInstance what;

        public DeliveryQuest(Character npc, Character toWhom, ItemInstance what, QuestImportance importance): base(npc, importance, QuestType.DELIVERY) {
            this.toWhom = toWhom;
            this.what = what;
        }
    }
}