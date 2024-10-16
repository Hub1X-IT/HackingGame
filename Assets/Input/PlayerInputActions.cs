//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/Input/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""All"",
            ""id"": ""0b743467-d1fe-4221-9b89-039eeaf463bb"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""67e90970-f792-4505-9853-0f2fbb229af3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ccfe2312-f3e6-4655-90af-6fea7b7602cf"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerWalkingAndDesk"",
            ""id"": ""4d7aed84-4714-4abd-b129-52277757db92"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""d57dce0d-08b7-47b5-bf9b-f1e5970acce9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""779c7c53-43e8-480a-99df-51dd49b0d68e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SmartphoneToggle"",
                    ""type"": ""Button"",
                    ""id"": ""ec7cb3d2-4248-4cf7-bae4-b2efd974dc60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5e723eb-09f7-47de-8c9d-40b9d644966f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b0ee327-bb7e-421a-91e4-6566c18a22b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abf23dd0-5b7f-4b2a-b160-e53c9bde3969"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SmartphoneToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerWalking"",
            ""id"": ""d03916ab-8bca-4e1d-b0c5-2392b4dc05d2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6e76317b-f5cb-4b92-b0d8-d7e5a43d7393"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""0d8dd9dd-adae-4da3-b52f-92800050a51d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ba082886-6d28-467e-98e0-af133293cefa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ddc2eb2-3a9c-46cb-95d0-5504606b1f0f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""84cca616-82aa-4599-aeea-ebc94dfa4ca0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12db8ae4-3d1f-42fb-acf1-fbf4eea48a14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Desk"",
            ""id"": ""69ef7312-dcbb-4a29-a88d-7ed7793b1001"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""Monitor"",
            ""id"": ""e92ca324-be7b-435a-b7b1-d850e85f4422"",
            ""actions"": [
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""7b6be9f5-8fed-4963-bc53-368e7f01d91f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""2651e297-53fd-426d-bda9-3bf0d473953a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Remove"",
                    ""type"": ""Button"",
                    ""id"": ""2127ceda-c8ea-4e4f-8709-81fae5dee2a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""19962de8-e56b-4786-ab33-54700e35800e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""48996b9e-577b-4ea7-a7b4-9bd4be7abbb1"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86cc0bc6-f8b9-41d3-94cb-9e1473d47aa1"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbc3b9f9-7490-4c9b-908c-b04047b47463"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""157f9962-13f1-48e9-896c-410fcd61ad42"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Remove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de083ec-0b8d-4de4-bd80-155fb6301931"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // All
        m_All = asset.FindActionMap("All", throwIfNotFound: true);
        m_All_Pause = m_All.FindAction("Pause", throwIfNotFound: true);
        // PlayerWalkingAndDesk
        m_PlayerWalkingAndDesk = asset.FindActionMap("PlayerWalkingAndDesk", throwIfNotFound: true);
        m_PlayerWalkingAndDesk_Rotate = m_PlayerWalkingAndDesk.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerWalkingAndDesk_Interact = m_PlayerWalkingAndDesk.FindAction("Interact", throwIfNotFound: true);
        m_PlayerWalkingAndDesk_SmartphoneToggle = m_PlayerWalkingAndDesk.FindAction("SmartphoneToggle", throwIfNotFound: true);
        // PlayerWalking
        m_PlayerWalking = asset.FindActionMap("PlayerWalking", throwIfNotFound: true);
        m_PlayerWalking_Move = m_PlayerWalking.FindAction("Move", throwIfNotFound: true);
        // Desk
        m_Desk = asset.FindActionMap("Desk", throwIfNotFound: true);
        // Monitor
        m_Monitor = asset.FindActionMap("Monitor", throwIfNotFound: true);
        m_Monitor_Submit = m_Monitor.FindAction("Submit", throwIfNotFound: true);
        m_Monitor_Keyboard = m_Monitor.FindAction("Keyboard", throwIfNotFound: true);
        m_Monitor_Remove = m_Monitor.FindAction("Remove", throwIfNotFound: true);
        m_Monitor_Exit = m_Monitor.FindAction("Exit", throwIfNotFound: true);
    }

    ~@PlayerInputActions()
    {
        UnityEngine.Debug.Assert(!m_All.enabled, "This will cause a leak and performance issues, PlayerInputActions.All.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_PlayerWalkingAndDesk.enabled, "This will cause a leak and performance issues, PlayerInputActions.PlayerWalkingAndDesk.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_PlayerWalking.enabled, "This will cause a leak and performance issues, PlayerInputActions.PlayerWalking.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Desk.enabled, "This will cause a leak and performance issues, PlayerInputActions.Desk.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Monitor.enabled, "This will cause a leak and performance issues, PlayerInputActions.Monitor.Disable() has not been called.");
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

    // All
    private readonly InputActionMap m_All;
    private List<IAllActions> m_AllActionsCallbackInterfaces = new List<IAllActions>();
    private readonly InputAction m_All_Pause;
    public struct AllActions
    {
        private @PlayerInputActions m_Wrapper;
        public AllActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_All_Pause;
        public InputActionMap Get() { return m_Wrapper.m_All; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AllActions set) { return set.Get(); }
        public void AddCallbacks(IAllActions instance)
        {
            if (instance == null || m_Wrapper.m_AllActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AllActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IAllActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IAllActions instance)
        {
            if (m_Wrapper.m_AllActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAllActions instance)
        {
            foreach (var item in m_Wrapper.m_AllActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AllActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AllActions @All => new AllActions(this);

    // PlayerWalkingAndDesk
    private readonly InputActionMap m_PlayerWalkingAndDesk;
    private List<IPlayerWalkingAndDeskActions> m_PlayerWalkingAndDeskActionsCallbackInterfaces = new List<IPlayerWalkingAndDeskActions>();
    private readonly InputAction m_PlayerWalkingAndDesk_Rotate;
    private readonly InputAction m_PlayerWalkingAndDesk_Interact;
    private readonly InputAction m_PlayerWalkingAndDesk_SmartphoneToggle;
    public struct PlayerWalkingAndDeskActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerWalkingAndDeskActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_PlayerWalkingAndDesk_Rotate;
        public InputAction @Interact => m_Wrapper.m_PlayerWalkingAndDesk_Interact;
        public InputAction @SmartphoneToggle => m_Wrapper.m_PlayerWalkingAndDesk_SmartphoneToggle;
        public InputActionMap Get() { return m_Wrapper.m_PlayerWalkingAndDesk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerWalkingAndDeskActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerWalkingAndDeskActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerWalkingAndDeskActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerWalkingAndDeskActionsCallbackInterfaces.Add(instance);
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @SmartphoneToggle.started += instance.OnSmartphoneToggle;
            @SmartphoneToggle.performed += instance.OnSmartphoneToggle;
            @SmartphoneToggle.canceled += instance.OnSmartphoneToggle;
        }

        private void UnregisterCallbacks(IPlayerWalkingAndDeskActions instance)
        {
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @SmartphoneToggle.started -= instance.OnSmartphoneToggle;
            @SmartphoneToggle.performed -= instance.OnSmartphoneToggle;
            @SmartphoneToggle.canceled -= instance.OnSmartphoneToggle;
        }

        public void RemoveCallbacks(IPlayerWalkingAndDeskActions instance)
        {
            if (m_Wrapper.m_PlayerWalkingAndDeskActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerWalkingAndDeskActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerWalkingAndDeskActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerWalkingAndDeskActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerWalkingAndDeskActions @PlayerWalkingAndDesk => new PlayerWalkingAndDeskActions(this);

    // PlayerWalking
    private readonly InputActionMap m_PlayerWalking;
    private List<IPlayerWalkingActions> m_PlayerWalkingActionsCallbackInterfaces = new List<IPlayerWalkingActions>();
    private readonly InputAction m_PlayerWalking_Move;
    public struct PlayerWalkingActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerWalkingActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerWalking_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerWalking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerWalkingActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerWalkingActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerWalkingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerWalkingActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerWalkingActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerWalkingActions instance)
        {
            if (m_Wrapper.m_PlayerWalkingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerWalkingActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerWalkingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerWalkingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerWalkingActions @PlayerWalking => new PlayerWalkingActions(this);

    // Desk
    private readonly InputActionMap m_Desk;
    private List<IDeskActions> m_DeskActionsCallbackInterfaces = new List<IDeskActions>();
    public struct DeskActions
    {
        private @PlayerInputActions m_Wrapper;
        public DeskActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Desk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DeskActions set) { return set.Get(); }
        public void AddCallbacks(IDeskActions instance)
        {
            if (instance == null || m_Wrapper.m_DeskActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DeskActionsCallbackInterfaces.Add(instance);
        }

        private void UnregisterCallbacks(IDeskActions instance)
        {
        }

        public void RemoveCallbacks(IDeskActions instance)
        {
            if (m_Wrapper.m_DeskActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDeskActions instance)
        {
            foreach (var item in m_Wrapper.m_DeskActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DeskActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DeskActions @Desk => new DeskActions(this);

    // Monitor
    private readonly InputActionMap m_Monitor;
    private List<IMonitorActions> m_MonitorActionsCallbackInterfaces = new List<IMonitorActions>();
    private readonly InputAction m_Monitor_Submit;
    private readonly InputAction m_Monitor_Keyboard;
    private readonly InputAction m_Monitor_Remove;
    private readonly InputAction m_Monitor_Exit;
    public struct MonitorActions
    {
        private @PlayerInputActions m_Wrapper;
        public MonitorActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Submit => m_Wrapper.m_Monitor_Submit;
        public InputAction @Keyboard => m_Wrapper.m_Monitor_Keyboard;
        public InputAction @Remove => m_Wrapper.m_Monitor_Remove;
        public InputAction @Exit => m_Wrapper.m_Monitor_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Monitor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MonitorActions set) { return set.Get(); }
        public void AddCallbacks(IMonitorActions instance)
        {
            if (instance == null || m_Wrapper.m_MonitorActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MonitorActionsCallbackInterfaces.Add(instance);
            @Submit.started += instance.OnSubmit;
            @Submit.performed += instance.OnSubmit;
            @Submit.canceled += instance.OnSubmit;
            @Keyboard.started += instance.OnKeyboard;
            @Keyboard.performed += instance.OnKeyboard;
            @Keyboard.canceled += instance.OnKeyboard;
            @Remove.started += instance.OnRemove;
            @Remove.performed += instance.OnRemove;
            @Remove.canceled += instance.OnRemove;
            @Exit.started += instance.OnExit;
            @Exit.performed += instance.OnExit;
            @Exit.canceled += instance.OnExit;
        }

        private void UnregisterCallbacks(IMonitorActions instance)
        {
            @Submit.started -= instance.OnSubmit;
            @Submit.performed -= instance.OnSubmit;
            @Submit.canceled -= instance.OnSubmit;
            @Keyboard.started -= instance.OnKeyboard;
            @Keyboard.performed -= instance.OnKeyboard;
            @Keyboard.canceled -= instance.OnKeyboard;
            @Remove.started -= instance.OnRemove;
            @Remove.performed -= instance.OnRemove;
            @Remove.canceled -= instance.OnRemove;
            @Exit.started -= instance.OnExit;
            @Exit.performed -= instance.OnExit;
            @Exit.canceled -= instance.OnExit;
        }

        public void RemoveCallbacks(IMonitorActions instance)
        {
            if (m_Wrapper.m_MonitorActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMonitorActions instance)
        {
            foreach (var item in m_Wrapper.m_MonitorActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MonitorActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MonitorActions @Monitor => new MonitorActions(this);
    public interface IAllActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerWalkingAndDeskActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSmartphoneToggle(InputAction.CallbackContext context);
    }
    public interface IPlayerWalkingActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IDeskActions
    {
    }
    public interface IMonitorActions
    {
        void OnSubmit(InputAction.CallbackContext context);
        void OnKeyboard(InputAction.CallbackContext context);
        void OnRemove(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
