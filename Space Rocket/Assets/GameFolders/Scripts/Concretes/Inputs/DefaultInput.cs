using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceRocket.Inputs
{
    public class DefaultInput
    {
        private DefaultActions _defaultActions;
        public bool isForceUp { get; private set; }
        public float leftRight { get; private set; }

        public DefaultInput()
        {
            _defaultActions = new DefaultActions();
            _defaultActions.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _defaultActions.Rocket.LeftRight.performed += context => leftRight = context.ReadValue<float>();
            _defaultActions.Enable();
        }
    }
}
