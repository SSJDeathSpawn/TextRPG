using TextRPG.Living;

namespace TextRPG.Story {
    public class Dialouge {
        
        public string line;
        public Character speaker;
        public Context context;

        public Dialouge(string line, Character speaker, Context context) {
            this.line = line;
            this.speaker = speaker;
            this.context = context;
        }

    }
}