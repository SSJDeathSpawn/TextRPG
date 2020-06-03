using TextRPG.Living;
using System;

namespace TextRPG.Story {
    public class Dialouge{
        
        public string line { get; set; }
        public Character speaker { get; set; }
        public Character speakingTo { get; set; }
        public Context context { get; set; }

        public Dialouge(string line, Character speaker, Context context) {
            this.line = line;
            this.speaker = speaker;
            this.context = context;
            this.speakingTo = null;
        }

        public Dialouge(string line, Character speaker, Character speakingTo, Context context) {
            this.line = line;
            this.speaker = speaker;
            this.context = context;
            this.speakingTo = speakingTo;
        }

    }
}