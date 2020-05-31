using System;
using System.Collections.Generic;
using TextRPG.Living;

namespace TextRPG.Story {
    public class QuestLine {
        List<Quest> quests;
        Character npc;

        public QuestLine(List<Quest> quests, Character npc) {
            this.quests = quests;
            this.npc = npc;
        }
    }
}