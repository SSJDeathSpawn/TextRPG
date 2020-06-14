using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TextRPG.Story.Control {
    public class FlowControl: IEnumerable<FlowObject>{
        public List<FlowObject> flowItems;

        public FlowControl(List<FlowObject> flowItems) {
            this.flowItems = flowItems;
        }

        public FlowControl(FlowObject[] flowItems) {
            this.flowItems = flowItems.ToList();
        }

        public IEnumerator<FlowObject> GetEnumerator() {
            return new Flow(this.flowItems);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return (IEnumerator) GetEnumerator();
        }
    }
}