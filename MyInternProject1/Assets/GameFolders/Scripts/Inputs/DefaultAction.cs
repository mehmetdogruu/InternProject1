//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameFolders/Scripts/Inputs/DefaultAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace MyInternProject1.Inputs
{
    public partial class @DefaultAction : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""8ccf1060-3167-4667-8318-df59e6299bc3"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""71166018-c8a5-44b4-bc34-b98e6bda5657"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1a123ce7-c937-4324-b074-00b584f87716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""047b1e49-d8b1-4d40-839b-0f244f556696"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AandD"",
                    ""id"": ""d6cf083d-8d77-487b-a878-4c6541297e4a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a17b94eb-1311-4b2e-9a03-c811c8d70bcb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7b39fa74-feed-4770-893a-56fb5ddc7844"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
            m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Rocket
        private readonly InputActionMap m_Rocket;
        private IRocketActions m_RocketActionsCallbackInterface;
        private readonly InputAction m_Rocket_ForceUp;
        private readonly InputAction m_Rocket_LeftRight;
        public struct RocketActions
        {
            private @DefaultAction m_Wrapper;
            public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void SetCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterface != null)
                {
                    @ForceUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @LeftRight.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                }
                m_Wrapper.m_RocketActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                }
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}