using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    abstract class State
    {
        public string Name { get; set; }
        public bool IsEndState { get; set; }
        public bool IsSuccessfulEnd = true;

        public void Callback(string letter, State nextState)
        {
            Console.WriteLine("Letter: " + letter + ", Current State: " + this.Name + ", Next State: " + nextState.Name);
        }

        protected string GetLetter(string payload)
        {
            return payload.Substring(0, 1);
        }

        protected string GetNewPayload(string payload)
        {
            return payload.Substring(1);
        }

        public abstract StateParseObject Run(string payload); 
    }
}
