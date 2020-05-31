using System;
using System.Collections.Generic;
using TextRPG.Living;

namespace TextRPG.Story {
    public class QuestLine {
        List<Quest> quests { get; set; }
        Character npc { get; set; }

        public QuestLine(List<Quest> quests, Character npc) {
            this.quests = quests;
            this.npc = npc;
        }
    }
}