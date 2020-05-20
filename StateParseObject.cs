using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    class StateParseObject
    {
        public string Payload { get; set; }
        public State NextState { get; set; }
    }
}
