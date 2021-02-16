using Zenject;
using app.state;
using UnityEngine;

namespace app.zenject
{
    public class State2 : State
    {
        private StateManager stateManager;

        public State2(StateManager stateManager)
        {
            this.stateManager = stateManager;
        }

        public override void Start()
        {
            Debug.Log("State2 loaded");
        }


        // Change to the next state
        private void ChangeState()
        {
            stateManager.ChangeState(States.State3.ToString());
        }

        public class Factory : PlaceholderFactory<State2> { }
    }
}