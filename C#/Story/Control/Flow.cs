using System;
using System.Collections.Generic;
using System.Collections;
using TextRPG.Story.Quests;
using TextRPG.Objects;
using TextRPG.Living;
using TextRPG.Data.Declarations;

namespace TextRPG.Story.Control {
    public class Flow: IEnumerator<FlowObject>{
        public List<FlowObject> flowItems;
        public string currentIndex;
        public FlowObject current;

        public FlowObject Current {get {
            return current;
        }}

        object IEnumerator.Current {get {
            return current;
        }}

        public Flow(List<FlowObject> flowItems) {
            this.flowItems = flowItems;
            this.currentIndex = "0";
            this.current = default(FlowObject);
        }

        public bool MoveNext() {
            string temp;
            temp = (Convert.ToInt16(currentIndex[0])+1).ToString() + currentIndex.Substring(1); 
            currentIndex = temp;
            foreach( FlowObject f in this.flowItems) {
                if(f.id == currentIndex) {
                    current = f;
                    return true;
                }
            }
            return false;
        }

        public void Reset() {
            string temp = "0";
            currentIndex = temp;
            this.current = default(FlowObject);
        }      

        void IDisposable.Dispose() { }  

        public bool MoveNextParallel() {
            string temp;
            if (currentIndex[currentIndex.Length-1] == 'z') {
                temp = currentIndex.Substring(1,currentIndex.Length-1) + "aa";
            } else if (Char.IsLetter(currentIndex[currentIndex.Length-1])) {
                temp = currentIndex.Substring(1,currentIndex.Length-1) + (currentIndex[currentIndex.Length-1] + 1);
            } else if(Char.IsDigit(currentIndex[currentIndex.Length-1])) {
                temp = currentIndex + "a";
            } else {
                throw new Exception(currentIndex + " is not correct");
            }
            foreach( FlowObject f in this.flowItems) {
                if(f.id == currentIndex) {
                    return true;
                }
            }
            return false;
        }
    }
}