using UnityEngine;

namespace app.state
{
    public abstract class StateManager 
    {
        public State State;

        public StateFactoryBase StateFactory;     

        public StateManager(StateFactoryBase StateFactory)
        {
            this.StateFactory = StateFactory;
        }


        public virtual void ChangeState(string _state)
        {
            //Debug.Log("Door State: " + _state);
            if (State != null)
            {
                State.Dispose();
                State = null;
            }

            State = StateFactory.CreateState(_state);
            State.Start();
        }
    }
}