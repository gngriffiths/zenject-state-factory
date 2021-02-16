using Zenject;
using app.state;
using UnityEngine;

namespace app.zenject
{
    public class State1 : State
    {
        private StateManager stateManager;

        public State1(StateManager stateManager)
        {
            this.stateManager = stateManager;
        }

        public override void Start()
        {
            Debug.Log("State1 loaded");
        }


        // Change to the next state
        private void ChangeState()
        {
            stateManager.ChangeState(States.State1.ToString());
        }

        public class Factory : PlaceholderFactory<State1> { }
    }
}