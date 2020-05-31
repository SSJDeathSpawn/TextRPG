namespace TextRPG.Living.Ailments {
    public class StatusInstance{
        public Status status { get; set; }
        public int modifier { get; set; }
        public StatusInstance(Status status, int modifier) {
            this.status = status;
            this.modifier = modifier;
        }

        public void applyStatus(Character character, int modifier) {
            status.doWork(character, modifier);
        }

    }
}