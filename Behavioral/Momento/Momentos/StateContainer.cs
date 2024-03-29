using System;
using Behavioral.Momento.Interfaces;

namespace Behavioral.Momento.Momentos
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    internal class StateContainer : IStateContainer
    {
        private readonly DateTime _date;
        private readonly string _state;

        public StateContainer(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return _state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}