namespace TextRPG.Story {
    public class Context {
        int lineNo { get; set; }
        bool inBattle { get; set; }
        
        public Context(int lineNo, bool inBattle) {
            this.lineNo = lineNo;
            this.inBattle = inBattle;
        }
    }
}