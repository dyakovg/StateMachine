using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.states
{
    class ErrorState : State
    {
        public ErrorState()
        {
            IsEndState = true;
            IsSuccessfulEnd = false;
        }
        public override StateParseObject Run(string payload)
        {
            string letter = this.GetLetter(payload);
            payload = GetNewPayload(payload);

            StateParseObject data = new StateParseObject();

            if (letter == "1")
            {
                data.NextState = this;
            }

            else if (letter == "0")
            {
                if (payload.Contains("0"))
                {
                    data.NextState = this;
                }
                else
                {
                    data.NextState = StateManager.Err;
                }
            }
            Callback(letter, data.NextState);
            data.Payload = payload;
            return data;
        }
    }
}
