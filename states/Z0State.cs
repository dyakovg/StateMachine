using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.states
{
    class Z0State : State
    {
        public Z0State()
        {
            IsEndState = false;
        }
        public override StateParseObject Run(string payload)
        {
            string letter = this.GetLetter(payload);
            payload = GetNewPayload(payload);

            StateParseObject data = new StateParseObject();

            if(letter == "1")
            {
                // z0
                data.NextState = StateManager.Z0;
            }

            else if(letter == "0")
            {
                if (payload.StartsWith("0") || payload.Length == 0)
                    data.NextState = StateManager.Z1;
                else
                    data.NextState = StateManager.Z0;
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
