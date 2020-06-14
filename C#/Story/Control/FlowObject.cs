using System;
using TextRPG.Living;

namespace TextRPG.Story.Control
{
    public class FlowObject {
        public string id { get; set; }
        public Flowable obj { get; set; }
        public Func<bool> condition  {get; set; }

    }
}