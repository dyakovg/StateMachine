using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    class StateMachine
    {
        public State BeginningState {get;}
        public StateMachine (State beginningState)
        {
            BeginningState = beginningState;
        }

        public bool Run(string word)
        {
            State state = BeginningState;

            while(true)
            {
                StateParseObject result = state.Run(word);
                word = result.Payload;
                state = result.NextState;

                if(!state.IsSuccessfulEnd)
                {
                    Console.WriteLine("Word is invalid");
                    return false;
                }

                if(word.Length == 0)
                {
                    if (state.IsEndState && state.IsSuccessfulEnd)
                    {
                        Console.WriteLine("Word is valid");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Word is invalid");
                        return false;
                    }
                }
            }
        }
    }
}
