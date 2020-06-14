using System;

namespace TextRPG.Story.Control {
    public interface Flowable {
         
        T returnFlowStuff<T>() where T: class;
        T returnFlowStuff<T>(int i) where T: class {
            throw new NotImplementedException(); 
        }
    }
}