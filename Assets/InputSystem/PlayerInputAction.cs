//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InputSystem/PlayerInputAction.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""fe9e0a6a-dc95-4a94-bd21-d55405efdbb4"",
            ""actions"": [
                {
                    ""name"": ""PlayAPitch"",
                    ""type"": ""Button"",
                    ""id"": ""3c6061aa-7124-4870-b5f2-61a614602ec5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayBPitch"",
                    ""type"": ""Button"",
                    ""id"": ""4bb93bea-7645-45aa-8000-1b58ed235a11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayCPitch"",
                    ""type"": ""Button"",
                    ""id"": ""caa35b81-b03d-466e-b53a-f88856a4f2dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayDPitch"",
                    ""type"": ""Button"",
                    ""id"": ""547106b7-5921-4301-986e-371eaba07677"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayEPitch"",
                    ""type"": ""Button"",
                    ""id"": ""2ec703a0-78fd-4dd0-9d9f-66daea69e8fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayFPitch"",
                    ""type"": ""Button"",
                    ""id"": ""e465ab62-4a3e-4588-bbea-dda668191f87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayGPitch"",
                    ""type"": ""Button"",
                    ""id"": ""52c39aa0-5aba-485f-8bbd-e9323d6c1172"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f5f25bb3-4609-4895-94a7-69d733c25ebf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4ac4775-0d04-4cbd-a53e-d5e3b4a938d3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayAPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1d0f12e-c1d3-429f-8b74-1706bf132576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayBPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8be8c671-06ff-4f28-addf-7dd1ab2964c2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayCPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb4f8644-5a68-481c-916c-205ab7db429f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayDPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2861076-607a-4254-ba98-a3ecdfc8cac0"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayEPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ca67adc-d1cc-4f0f-9206-c42779f74683"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayFPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d000c3b-44b6-4462-9ea4-20223db334b6"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayGPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce61d889-7ec3-417e-9b7a-0c2b8fb7703f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PlayAPitch = m_Player.FindAction("PlayAPitch", throwIfNotFound: true);
        m_Player_PlayBPitch = m_Player.FindAction("PlayBPitch", throwIfNotFound: true);
        m_Player_PlayCPitch = m_Player.FindAction("PlayCPitch", throwIfNotFound: true);
        m_Player_PlayDPitch = m_Player.FindAction("PlayDPitch", throwIfNotFound: true);
        m_Player_PlayEPitch = m_Player.FindAction("PlayEPitch", throwIfNotFound: true);
        m_Player_PlayFPitch = m_Player.FindAction("PlayFPitch", throwIfNotFound: true);
        m_Player_PlayGPitch = m_Player.FindAction("PlayGPitch", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_PlayAPitch;
    private readonly InputAction m_Player_PlayBPitch;
    private readonly InputAction m_Player_PlayCPitch;
    private readonly InputAction m_Player_PlayDPitch;
    private readonly InputAction m_Player_PlayEPitch;
    private readonly InputAction m_Player_PlayFPitch;
    private readonly InputAction m_Player_PlayGPitch;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayAPitch => m_Wrapper.m_Player_PlayAPitch;
        public InputAction @PlayBPitch => m_Wrapper.m_Player_PlayBPitch;
        public InputAction @PlayCPitch => m_Wrapper.m_Player_PlayCPitch;
        public InputAction @PlayDPitch => m_Wrapper.m_Player_PlayDPitch;
        public InputAction @PlayEPitch => m_Wrapper.m_Player_PlayEPitch;
        public InputAction @PlayFPitch => m_Wrapper.m_Player_PlayFPitch;
        public InputAction @PlayGPitch => m_Wrapper.m_Player_PlayGPitch;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @PlayAPitch.started += instance.OnPlayAPitch;
            @PlayAPitch.performed += instance.OnPlayAPitch;
            @PlayAPitch.canceled += instance.OnPlayAPitch;
            @PlayBPitch.started += instance.OnPlayBPitch;
            @PlayBPitch.performed += instance.OnPlayBPitch;
            @PlayBPitch.canceled += instance.OnPlayBPitch;
            @PlayCPitch.started += instance.OnPlayCPitch;
            @PlayCPitch.performed += instance.OnPlayCPitch;
            @PlayCPitch.canceled += instance.OnPlayCPitch;
            @PlayDPitch.started += instance.OnPlayDPitch;
            @PlayDPitch.performed += instance.OnPlayDPitch;
            @PlayDPitch.canceled += instance.OnPlayDPitch;
            @PlayEPitch.started += instance.OnPlayEPitch;
            @PlayEPitch.performed += instance.OnPlayEPitch;
            @PlayEPitch.canceled += instance.OnPlayEPitch;
            @PlayFPitch.started += instance.OnPlayFPitch;
            @PlayFPitch.performed += instance.OnPlayFPitch;
            @PlayFPitch.canceled += instance.OnPlayFPitch;
            @PlayGPitch.started += instance.OnPlayGPitch;
            @PlayGPitch.performed += instance.OnPlayGPitch;
            @PlayGPitch.canceled += instance.OnPlayGPitch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @PlayAPitch.started -= instance.OnPlayAPitch;
            @PlayAPitch.performed -= instance.OnPlayAPitch;
            @PlayAPitch.canceled -= instance.OnPlayAPitch;
            @PlayBPitch.started -= instance.OnPlayBPitch;
            @PlayBPitch.performed -= instance.OnPlayBPitch;
            @PlayBPitch.canceled -= instance.OnPlayBPitch;
            @PlayCPitch.started -= instance.OnPlayCPitch;
            @PlayCPitch.performed -= instance.OnPlayCPitch;
            @PlayCPitch.canceled -= instance.OnPlayCPitch;
            @PlayDPitch.started -= instance.OnPlayDPitch;
            @PlayDPitch.performed -= instance.OnPlayDPitch;
            @PlayDPitch.canceled -= instance.OnPlayDPitch;
            @PlayEPitch.started -= instance.OnPlayEPitch;
            @PlayEPitch.performed -= instance.OnPlayEPitch;
            @PlayEPitch.canceled -= instance.OnPlayEPitch;
            @PlayFPitch.started -= instance.OnPlayFPitch;
            @PlayFPitch.performed -= instance.OnPlayFPitch;
            @PlayFPitch.canceled -= instance.OnPlayFPitch;
            @PlayGPitch.started -= instance.OnPlayGPitch;
            @PlayGPitch.performed -= instance.OnPlayGPitch;
            @PlayGPitch.canceled -= instance.OnPlayGPitch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPlayAPitch(InputAction.CallbackContext context);
        void OnPlayBPitch(InputAction.CallbackContext context);
        void OnPlayCPitch(InputAction.CallbackContext context);
        void OnPlayDPitch(InputAction.CallbackContext context);
        void OnPlayEPitch(InputAction.CallbackContext context);
        void OnPlayFPitch(InputAction.CallbackContext context);
        void OnPlayGPitch(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
