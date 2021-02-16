using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace app.zenject
{
    public class InstallerStateFactory : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<StateManagerAddName>().AsSingle();
            Container.Bind<StateFactoryAddName>().AsSingle();
            Container.BindFactory<State1, State1.Factory>().WhenInjectedInto<StateFactoryAddName>();
            Container.BindFactory<State2, State2.Factory>().WhenInjectedInto<StateFactoryAddName>();
            Container.BindFactory<State3, State3.Factory>().WhenInjectedInto<StateFactoryAddName>();
        }
    }
}