using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyInternProject1.Inputs

{
    public class DefaultInput
    {
        private DefaultAction _input;

        public bool isForceUp { get; private set; }
        public float leftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => leftRight = context.ReadValue<float>();
            _input.Enable();
        }
    }

}

