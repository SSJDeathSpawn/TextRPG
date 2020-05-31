using TextRPG.Living;

namespace TextRPG.Story {
    public class Dialouge {
        
        public string line { get; set; }
        public Character speaker { get; set; }
        public Context context { get; set; }

        public Dialouge(string line, Character speaker, Context context) {
            this.line = line;
            this.speaker = speaker;
            this.context = context;
        }

    }
}