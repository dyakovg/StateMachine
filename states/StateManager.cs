using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.states
{
    class StateManager
    {
        public static Z0State Z0
        {
            get
            {
                if(z0 == null)
                {
                    z0 = new Z0State();
                    z0.Name = "Z0";
                }
                return z0;
            }
        }
        public static Z1State Z1
        {
            get
            {
                if (z1 == null)
                {
                    z1 = new Z1State();
                    z1.Name = "Z1";
                }
                return z1;
            }
        }
        public static Z2State Z2
        {
            get
            {
                if (z2 == null)
                {
                    z2 = new Z2State();
                    z2.Name = "Z2";
                }
                return z2;
            }
        }
        public static ErrorState Err
        {
            get
            {
                if (err == null)
                {
                    err = new ErrorState();
                    err.Name = "Error";
                }
                return err;
            }
        }

        private static Z0State z0;
        private static Z1State z1;
        private static Z2State z2;
        private static ErrorState err;
    }
}
