using System;
using StateMachine.states;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine(StateManager.Z0);
            Console.WriteLine("Type word");
            string word = Console.ReadLine();
            machine.Run(word);

            Console.ReadKey();
        }
    }
}
