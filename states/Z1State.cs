using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.states
{
    class Z1State : State
    {
        public Z1State()
        {
            IsEndState = true;
        }
        public override StateParseObject Run(string payload)
        {
            string letter = this.GetLetter(payload);
            payload = GetNewPayload(payload);

            StateParseObject data = new StateParseObject();

            if (letter == "0")
            {
                data.NextState = StateManager.Z2;
            } 
            
            else
            {
                data.NextState = StateManager.Err;
            }

            Callback(letter, data.NextState);
            data.Payload = payload;
            return data;
        }
    }
}
