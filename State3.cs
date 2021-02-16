using Zenject;
using app.state;
using UnityEngine;

namespace app.zenject
{
    public class State3 : State
    {
        private StateManager stateManager;

        public State3(StateManager stateManager)
        {
            this.stateManager = stateManager;
        }

        public override void Start()
        {
            Debug.Log("State3 loaded");
        }


        // Change to the next state
        private void ChangeState()
        {
            stateManager.ChangeState(States.State1.ToString());
        }

        public class Factory : PlaceholderFactory<State3> { }
    }
}