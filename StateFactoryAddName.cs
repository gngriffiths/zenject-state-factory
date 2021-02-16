using app.extension;
using app.state;
using ModestTree;

namespace app.zenject
{
    public enum States
    {
        State1,
        State2,
        State3
    }

    public class StateFactoryAddName : StateFactoryBase
    {
        private EnumConverter enumConverter;

        private State1.Factory state1;
        private State2.Factory state2;
        private State3.Factory state3;



        public StateFactoryAddName(
            EnumConverter enumConverter,
            State1.Factory state1,
            State2.Factory state2,
            State3.Factory state3
            )
        {
            this.enumConverter = enumConverter;
            this.state1 = state1;
            this.state2 = state2;
            this.state3 = state3;
        }

        public override State CreateState(string _state)
        {
            var state = enumConverter.GetEnumStringEnumType<States>(_state);

            switch (state)
            {
                case States.State1:
                    {
                        return state1.Create();
                    }
                case States.State2:
                    {
                        return state2.Create();
                    }
                case States.State3:
                    {
                        return state3.Create();
                    }
            }

            throw Assert.CreateException();
        }
    }
}