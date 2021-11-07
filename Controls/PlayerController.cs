// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7c0d8329-8b50-4ab0-91ef-2bf7a2341a66"",
            ""actions"": [
                {
                    ""name"": ""Pedal"",
                    ""type"": ""Value"",
                    ""id"": ""2145ae98-3451-49a8-99df-5ff4ed0b408b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeanLR"",
                    ""type"": ""Value"",
                    ""id"": ""cfac1a0e-f1d6-4f6a-9438-12816efdc9d4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnLR"",
                    ""type"": ""Value"",
                    ""id"": ""08c5bd27-dfa3-40bf-ac5e-f0d2142b9778"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltFB"",
                    ""type"": ""Value"",
                    ""id"": ""2e71e655-2531-4d8b-b5f3-be15eac1c099"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftWeight"",
                    ""type"": ""Value"",
                    ""id"": ""5221479a-976a-40e3-9b1b-4b5f3eacec09"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""f950102d-ec19-4410-99a0-e3b33ef926d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Launch"",
                    ""type"": ""Button"",
                    ""id"": ""674a48d4-60e4-42a3-8f81-aab584dd2823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""JumpCancel"",
                    ""type"": ""Button"",
                    ""id"": ""812f8e59-6a04-4e19-a7a1-6f8e7c0aefb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AirMovement"",
                    ""type"": ""Value"",
                    ""id"": ""40cef8cf-c271-41c0-b3ca-1ad28ba8b75f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AirRotation"",
                    ""type"": ""Value"",
                    ""id"": ""70d7fda6-a5fe-4c96-9db2-6e07f5032116"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""a311c918-919d-40b9-ad0f-761a33f5529f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ping"",
                    ""type"": ""Button"",
                    ""id"": ""3533ecf7-1e03-4271-8805-5f3fdb12d9f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Triggers"",
                    ""id"": ""94fd8eae-0cd3-47ca-84d5-e22a48382b16"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aabf3c03-823c-4ba0-a637-aa1d4f44e187"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f572d2c9-ca9a-4dbe-9760-2048fe63f79c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""W & S "",
                    ""id"": ""cce5e826-4a85-4e82-bf1e-76831d51e542"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7a32950f-74ff-481e-92f9-9f218d87b2f4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""158406c3-571d-4ff9-ac24-080db1db5477"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows U & D"",
                    ""id"": ""f65fa4c1-e9be-469b-b279-995f6f3b4a49"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""14ee8d5b-556d-47eb-b55c-85b12591241e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7b4fee2d-8ea7-42e1-876c-0db6e8d31c4e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""R Stick"",
                    ""id"": ""c97d6bb1-b716-44f0-b813-e5da8dbbc35c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""95ba5dc9-9878-4741-9fc3-844731940249"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""df6b05af-4f6f-421f-ae07-eca312d13b7f"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows L & R"",
                    ""id"": ""42a02410-8e5f-47be-b2c9-8d6c01c275fd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""21ca6581-6068-496b-b9eb-f7b2118005a8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c4cbba24-b47d-4d86-8b96-bec5d2e700a7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": "" L Stick"",
                    ""id"": ""cd47d33a-797a-4ff0-9979-cdeb4df24775"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""08d32e6e-af78-4b09-87c9-b6aa0dfacc89"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TurnLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c0db8893-a7ff-4c4c-b594-656a8edc5e30"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TurnLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""A & D"",
                    ""id"": ""109a498e-9fef-42e5-9f5c-46dfc6b668c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6934f02f-9a64-40ff-ba7c-a6ef9594e754"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""TurnLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""52664881-7839-42fa-b4d5-b63215a80c95"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""TurnLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""R Stick"",
                    ""id"": ""9ed7da73-7e89-4dbc-a77f-90a8f3f943be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TiltFB"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""764b702f-e811-4edf-b14c-ee92c7f22103"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f62dbd00-2951-455e-9432-96b651a6a402"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows U & D"",
                    ""id"": ""94b5cbc8-b9fa-447f-a275-4b502e374bde"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TiltFB"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bc9d0b1d-8283-4c5c-b6fe-56a5c126a505"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1eef4bf8-e052-42ba-8482-6fce6695a754"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4bae118e-eb8a-4147-af31-9a36975a4194"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""4001d779-7909-42dc-936a-049f6f5b39f4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""83ff8f95-ee9a-4440-bfd6-4f0dbc1bfaaf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4be6fd64-a9c9-4b74-88b5-804965f4bfc5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f92359ce-00a5-4287-9e8c-44df7bb31d40"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""57147996-93b1-4229-bd3c-56b7e1b4ca2f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3c6b67b-6c1e-4975-ad53-c980a0b5e52a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10774d45-7f27-4f03-a588-18522707df9c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c2050b5-a0c9-44e5-abf1-bf71ad9e0c38"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c63ee8d-d53b-484a-b540-fe7f3db2430e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74f67823-e308-4c5b-a222-96140aa3cd59"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JumpCancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94b51e5f-d79b-4534-bbff-3cbefa0c4311"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""JumpCancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20e92c0b-c279-44e8-89b4-a26b1065dc78"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d2704d35-d46a-4078-b2d5-a266a094db48"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""321a2526-8275-4144-816c-3b63e761fb23"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a900ab09-c710-432f-b2ed-af2ca8d2e261"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9631daca-f9b5-4c9a-8db5-5cddff4e2a47"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb82dc4f-fc00-4df2-a5c8-f3f6c40a465b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9a8f9ea4-2037-4192-ab30-c18e9846062c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""1e04cf96-fe78-43d1-86ee-412e6fdfc0a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99e2d68d-a0b5-4aa1-a915-a023d5c15cf2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""631aba12-4f21-4f02-8448-b3cf4421e955"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c4fa6ee3-4b67-4731-bf91-69d8ad29f2b7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""933eaa78-307a-4a9a-9d2e-8b8a4ec5d884"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3f181010-dc2d-4ed8-8614-14f3a5cf74c6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99a46245-99f3-4927-a2b9-60cf29c77133"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25546405-7797-4318-a62e-8e5efbb5404d"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dcf4235-254a-40fa-a08c-c8240d4a6d39"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""74559d76-c586-4476-bd48-c37f9e72d390"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""8ee3f41d-fafa-4533-a25b-1a588c376ec2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""5cd38a53-053a-40ec-9c4d-46beca498d34"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b9a49b24-08f4-4ade-8610-14abfa4d4449"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""281eccdc-d4c0-4a4b-8f82-05b521772b5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ed0e907-8ca4-4a3a-be92-540a76ed8a55"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3dcb658-4fb6-4492-a6bd-3830ae950428"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5b2975e-ae7c-4f8f-a789-fa16e26f6a59"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6094af0a-1437-4349-9c58-baebc68ff9cd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbd5f43c-223a-4f1f-bf5d-bdde76109ef2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""798d9c09-914c-438e-b451-99122649b0c6"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""509afd5f-7bc0-4f2e-8efa-7340de0a8c1e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aee83eb3-930a-40b3-b3cc-2c1aa66e970a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""abd6773b-9d52-4653-a673-c722ac8e4ce8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fa509ed1-038b-44d6-b53f-1f415ea80c8d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""72a258e8-7d38-4a38-a446-dc7e70a28bb1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2db3a46d-1eaa-42db-b3c1-c3b1304465e9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""2985c9c4-da0d-441c-8eb5-d5780a6d10c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1febf6d-52fc-41b6-9304-021f950f373a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5e634873-f7d4-4f70-8b18-85b72a623a5a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1a0c1dc2-cb24-4b71-be50-118759652630"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba9a4c35-ffb3-49fa-ac49-0a883b87d387"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""478ad754-0b76-4f0c-83af-3358262feccb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""617dba7c-4471-4bd2-98a9-d6bb1a76b606"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c15f8593-8f48-4cdc-b7ad-c2ce5bd1d0bb"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c6bc9d0-97fc-4581-b5af-ce59127e0ff4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14394a65-9857-4458-b74e-7cdc51bc2d49"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0937b5e-36f5-4dba-b80e-1190ea5f2e12"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03204205-6615-405e-bd66-1ed645d0ab33"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e0134db-c851-4f7f-be9b-9d91b03af7f8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbfde581-ec45-405e-9c27-d79495f5601d"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf912a52-c5c2-4241-b058-91b19c268be6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K & M"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""K & M"",
            ""bindingGroup"": ""K & M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Pedal = m_Gameplay.FindAction("Pedal", throwIfNotFound: true);
        m_Gameplay_LeanLR = m_Gameplay.FindAction("LeanLR", throwIfNotFound: true);
        m_Gameplay_TurnLR = m_Gameplay.FindAction("TurnLR", throwIfNotFound: true);
        m_Gameplay_TiltFB = m_Gameplay.FindAction("TiltFB", throwIfNotFound: true);
        m_Gameplay_ShiftWeight = m_Gameplay.FindAction("ShiftWeight", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Launch = m_Gameplay.FindAction("Launch", throwIfNotFound: true);
        m_Gameplay_JumpCancel = m_Gameplay.FindAction("JumpCancel", throwIfNotFound: true);
        m_Gameplay_AirMovement = m_Gameplay.FindAction("AirMovement", throwIfNotFound: true);
        m_Gameplay_AirRotation = m_Gameplay.FindAction("AirRotation", throwIfNotFound: true);
        m_Gameplay_Reset = m_Gameplay.FindAction("Reset", throwIfNotFound: true);
        m_Gameplay_Ping = m_Gameplay.FindAction("Ping", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_Back = m_UI.FindAction("Back", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Pedal;
    private readonly InputAction m_Gameplay_LeanLR;
    private readonly InputAction m_Gameplay_TurnLR;
    private readonly InputAction m_Gameplay_TiltFB;
    private readonly InputAction m_Gameplay_ShiftWeight;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Launch;
    private readonly InputAction m_Gameplay_JumpCancel;
    private readonly InputAction m_Gameplay_AirMovement;
    private readonly InputAction m_Gameplay_AirRotation;
    private readonly InputAction m_Gameplay_Reset;
    private readonly InputAction m_Gameplay_Ping;
    public struct GameplayActions
    {
        private @PlayerController m_Wrapper;
        public GameplayActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pedal => m_Wrapper.m_Gameplay_Pedal;
        public InputAction @LeanLR => m_Wrapper.m_Gameplay_LeanLR;
        public InputAction @TurnLR => m_Wrapper.m_Gameplay_TurnLR;
        public InputAction @TiltFB => m_Wrapper.m_Gameplay_TiltFB;
        public InputAction @ShiftWeight => m_Wrapper.m_Gameplay_ShiftWeight;
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        public InputAction @Launch => m_Wrapper.m_Gameplay_Launch;
        public InputAction @JumpCancel => m_Wrapper.m_Gameplay_JumpCancel;
        public InputAction @AirMovement => m_Wrapper.m_Gameplay_AirMovement;
        public InputAction @AirRotation => m_Wrapper.m_Gameplay_AirRotation;
        public InputAction @Reset => m_Wrapper.m_Gameplay_Reset;
        public InputAction @Ping => m_Wrapper.m_Gameplay_Ping;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Pedal.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPedal;
                @Pedal.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPedal;
                @Pedal.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPedal;
                @LeanLR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeanLR;
                @LeanLR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeanLR;
                @LeanLR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeanLR;
                @TurnLR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurnLR;
                @TurnLR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurnLR;
                @TurnLR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurnLR;
                @TiltFB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @TiltFB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @TiltFB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @ShiftWeight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @ShiftWeight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @ShiftWeight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @Crouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Launch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @Launch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @Launch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @JumpCancel.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @JumpCancel.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @JumpCancel.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @AirMovement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirMovement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirMovement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirRotation.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @AirRotation.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @AirRotation.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @Reset.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Ping.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
                @Ping.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
                @Ping.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pedal.started += instance.OnPedal;
                @Pedal.performed += instance.OnPedal;
                @Pedal.canceled += instance.OnPedal;
                @LeanLR.started += instance.OnLeanLR;
                @LeanLR.performed += instance.OnLeanLR;
                @LeanLR.canceled += instance.OnLeanLR;
                @TurnLR.started += instance.OnTurnLR;
                @TurnLR.performed += instance.OnTurnLR;
                @TurnLR.canceled += instance.OnTurnLR;
                @TiltFB.started += instance.OnTiltFB;
                @TiltFB.performed += instance.OnTiltFB;
                @TiltFB.canceled += instance.OnTiltFB;
                @ShiftWeight.started += instance.OnShiftWeight;
                @ShiftWeight.performed += instance.OnShiftWeight;
                @ShiftWeight.canceled += instance.OnShiftWeight;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Launch.started += instance.OnLaunch;
                @Launch.performed += instance.OnLaunch;
                @Launch.canceled += instance.OnLaunch;
                @JumpCancel.started += instance.OnJumpCancel;
                @JumpCancel.performed += instance.OnJumpCancel;
                @JumpCancel.canceled += instance.OnJumpCancel;
                @AirMovement.started += instance.OnAirMovement;
                @AirMovement.performed += instance.OnAirMovement;
                @AirMovement.canceled += instance.OnAirMovement;
                @AirRotation.started += instance.OnAirRotation;
                @AirRotation.performed += instance.OnAirRotation;
                @AirRotation.canceled += instance.OnAirRotation;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Ping.started += instance.OnPing;
                @Ping.performed += instance.OnPing;
                @Ping.canceled += instance.OnPing;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_Back;
    public struct UIActions
    {
        private @PlayerController m_Wrapper;
        public UIActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @Back => m_Wrapper.m_UI_Back;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Back.started -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K & M");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnPedal(InputAction.CallbackContext context);
        void OnLeanLR(InputAction.CallbackContext context);
        void OnTurnLR(InputAction.CallbackContext context);
        void OnTiltFB(InputAction.CallbackContext context);
        void OnShiftWeight(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLaunch(InputAction.CallbackContext context);
        void OnJumpCancel(InputAction.CallbackContext context);
        void OnAirMovement(InputAction.CallbackContext context);
        void OnAirRotation(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnPing(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
