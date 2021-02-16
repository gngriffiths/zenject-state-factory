using app.state;
using Zenject;

// This class has StateManager as a base. The ChangeState() method is used to pass in a string name for the state to change to

namespace app.zenject
{
    public class StateManagerAddName : StateManager, IInitializable
    {
        public StateManagerAddName(StateFactoryAddName playerMovement_StateFactory) : base (playerMovement_StateFactory){ }     // Pass the factory to the base
        

        public void Initialize()
        {
            ChangeState(States.State1.ToString());
        }
    }
}