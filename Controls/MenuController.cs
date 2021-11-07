// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/MenuController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuController"",
    ""maps"": [
        {
            ""name"": ""MainMenu"",
            ""id"": ""eaa111c1-bc1f-4c93-a253-d7471acb1e40"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""8f9b098d-780a-48fa-bdcc-a2a12e6984c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7a140f84-a158-4ff9-9efd-c79723e44efc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cdfa735-c65c-450e-a978-26aab407c6df"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f39db7d8-da87-4b80-b46d-bd2457711e9e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""3c78356d-fb14-4c64-9c12-4f05107d0f86"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0a295027-c9e2-442e-919a-0939847c2040"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""fd215316-7e8a-4c95-866a-0523828f8058"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""05dcf855-4100-4139-9d07-350257c29ec4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""ede62a4c-9de2-4b90-885a-5547e9329408"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateUp/Down"",
                    ""type"": ""Button"",
                    ""id"": ""dce5ab3e-43a3-4a7b-b5d0-e2c1ba61419a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf5d4e0b-8bde-4e60-b5c2-5d4e2a6b8250"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7da3b04a-b219-45dc-b6ee-d210ffe23325"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""4865559d-208f-4e64-92ee-5b153e1daee4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""697f44fb-27fe-44a1-b401-02de753a6c44"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7db27683-c2ab-4e6f-b9b0-c7ae02a03f31"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""e5695fc2-a4ef-460a-88de-3dce75d89193"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1fb0f434-b5b8-4831-9678-acfd0c1ea051"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""adad4532-6b53-418d-835d-219711cfba87"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d888b84-d46e-4917-892f-0a73445fa317"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab5db5d3-85bf-4414-be75-e4b612c24f26"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f4f8551-ee15-48bf-8db8-17271de0bde2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4cda50ce-f740-4f86-b2d9-be212cc5706e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateUp/Down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2764d302-cf31-4008-a623-ba9411ea24da"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateUp/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""120c8f7c-0ad2-48f3-96c0-bab80f1086ce"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MenuControls"",
                    ""action"": ""NavigateUp/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MenuControls"",
            ""bindingGroup"": ""MenuControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MainMenu
        m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
        m_MainMenu_Select = m_MainMenu.FindAction("Select", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_Pause = m_PauseMenu.FindAction("Pause", throwIfNotFound: true);
        m_PauseMenu_Navigate = m_PauseMenu.FindAction("Navigate", throwIfNotFound: true);
        m_PauseMenu_Select = m_PauseMenu.FindAction("Select", throwIfNotFound: true);
        m_PauseMenu_Back = m_PauseMenu.FindAction("Back", throwIfNotFound: true);
        m_PauseMenu_NavigateUpDown = m_PauseMenu.FindAction("NavigateUp/Down", throwIfNotFound: true);
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

    // MainMenu
    private readonly InputActionMap m_MainMenu;
    private IMainMenuActions m_MainMenuActionsCallbackInterface;
    private readonly InputAction m_MainMenu_Select;
    public struct MainMenuActions
    {
        private @MenuController m_Wrapper;
        public MainMenuActions(@MenuController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_MainMenu_Select;
        public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public MainMenuActions @MainMenu => new MainMenuActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private IPauseMenuActions m_PauseMenuActionsCallbackInterface;
    private readonly InputAction m_PauseMenu_Pause;
    private readonly InputAction m_PauseMenu_Navigate;
    private readonly InputAction m_PauseMenu_Select;
    private readonly InputAction m_PauseMenu_Back;
    private readonly InputAction m_PauseMenu_NavigateUpDown;
    public struct PauseMenuActions
    {
        private @MenuController m_Wrapper;
        public PauseMenuActions(@MenuController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_PauseMenu_Pause;
        public InputAction @Navigate => m_Wrapper.m_PauseMenu_Navigate;
        public InputAction @Select => m_Wrapper.m_PauseMenu_Select;
        public InputAction @Back => m_Wrapper.m_PauseMenu_Back;
        public InputAction @NavigateUpDown => m_Wrapper.m_PauseMenu_NavigateUpDown;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnPause;
                @Navigate.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Select.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
                @Back.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnBack;
                @NavigateUpDown.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigateUpDown;
                @NavigateUpDown.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigateUpDown;
                @NavigateUpDown.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigateUpDown;
            }
            m_Wrapper.m_PauseMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @NavigateUpDown.started += instance.OnNavigateUpDown;
                @NavigateUpDown.performed += instance.OnNavigateUpDown;
                @NavigateUpDown.canceled += instance.OnNavigateUpDown;
            }
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    private int m_MenuControlsSchemeIndex = -1;
    public InputControlScheme MenuControlsScheme
    {
        get
        {
            if (m_MenuControlsSchemeIndex == -1) m_MenuControlsSchemeIndex = asset.FindControlSchemeIndex("MenuControls");
            return asset.controlSchemes[m_MenuControlsSchemeIndex];
        }
    }
    public interface IMainMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnNavigateUpDown(InputAction.CallbackContext context);
    }
}
