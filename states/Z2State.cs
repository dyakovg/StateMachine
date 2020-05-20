using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.states
{
    class Z2State : State
    {
        public Z2State()
        {
            IsEndState = true;
        }
        public override StateParseObject Run(string payload)
        {
            string letter = this.GetLetter(payload);
            payload = GetNewPayload(payload);

            StateParseObject data = new StateParseObject();

            if (letter == "1" || letter == "0")
            {
                // z0
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
