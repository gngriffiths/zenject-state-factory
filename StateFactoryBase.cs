using System;

namespace app.state
{
    public abstract class StateFactoryBase
    {
        public abstract State CreateState(string _state);
    }
}