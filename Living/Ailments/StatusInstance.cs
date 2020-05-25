namespace TextRPG.Living.Ailments {
    public class StatusInstance{
        public Status status;
        public int modifier;
        public StatusInstance(Status status, int modifier) {
            this.status = status;
            this.modifier = modifier;
        }

        public void applyStatus(Character character, int modifier) {
            status.doWork(character, modifier);
        }

    }
}