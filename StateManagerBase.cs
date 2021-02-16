using System;

namespace app.state
{
    public class StateManagerBase
    {
        public State ActiveState;       

        public StateFactoryBase StateFactory;


        public virtual void ChangeState(string _state)
        {
            if (ActiveState != null)
            {
                ActiveState.Dispose();
                ActiveState = null;
            }

            ActiveState = StateFactory.CreateState(_state);
            ActiveState.Start();
        }
    }
}