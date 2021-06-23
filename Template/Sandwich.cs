using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public abstract class AbstractPreFlightCheckList
    {
        // This method captures the template or the skeleton
        // of the algorithm for the pre-flight checklist.
        public void runChecklist()
        {
            IsFuelEnough();
            if(hasDoor())
            doorsLocked();
            checkAirPressure();
        }

        protected virtual bool hasDoor()
        {
            return true;
        }

        // Don't let subclasses override this method, this is a
        // mandatory check
        protected void IsFuelEnough()
        {
            Console.WriteLine("check fuel gauge");
        }
        // Some airplanes may or may not have doors so allow this
        // method to be overridden by subclasses
        protected virtual bool doorsLocked()
        {
            Console.WriteLine("standard way to check door..");
            return true;
        }
        // Force subclasses to provide their own way of checking for
        // cabin or cockpit air pressure
        protected abstract void checkAirPressure();
    }


}
