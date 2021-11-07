// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/UnicycleController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UnicycleController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UnicycleController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UnicycleController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""946fb572-dd3e-4d49-9841-0d92664c2ea0"",
            ""actions"": [
                {
                    ""name"": ""Pedal"",
                    ""type"": ""Value"",
                    ""id"": ""bb5e7108-9314-4c7d-871c-b0e8996307a8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeanLR"",
                    ""type"": ""Value"",
                    ""id"": ""0112c5ff-a3cc-44da-9717-bf85590e6d2a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltFB"",
                    ""type"": ""Value"",
                    ""id"": ""8ccf8308-46b2-4f8d-aef9-2f0601eab36a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""89a14641-3c7d-45f7-9021-144525a3a7a3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftWeight"",
                    ""type"": ""Value"",
                    ""id"": ""dbbe8545-3258-4b4b-9c57-66cb3be5b4d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""1c80cddf-66f9-4889-9c6c-375ff51dfcea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Launch"",
                    ""type"": ""Button"",
                    ""id"": ""44fa3054-8462-4859-9bcd-cdd7b2381b6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""AirMovement"",
                    ""type"": ""Value"",
                    ""id"": ""da54aa03-396c-4b14-94a0-fa572492ed99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AirRotation"",
                    ""type"": ""Value"",
                    ""id"": ""d033fa88-261a-4854-a4c7-4250cf060de4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ping"",
                    ""type"": ""Button"",
                    ""id"": ""f48a3398-275c-43f2-b3f7-e978768af7a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpCancel"",
                    ""type"": ""Button"",
                    ""id"": ""d8b05606-d6bb-4591-bc66-2c0c276dceb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pogo"",
                    ""type"": ""Value"",
                    ""id"": ""c8b29495-e33b-4026-a5b3-38a4d8d65916"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.2,pressPoint=0.3)""
                },
                {
                    ""name"": ""Hop"",
                    ""type"": ""Button"",
                    ""id"": ""21a04b3a-b7b3-447d-ac69-c0ce1a56110f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Value"",
                    ""id"": ""5f59bd04-e6a6-42ee-9df8-567b10893efe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetRotPos"",
                    ""type"": ""Button"",
                    ""id"": ""c9f91472-a760-4997-a999-afd3c5a53f8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Right Stick LR"",
                    ""id"": ""495dad6c-edf4-4ac1-b61e-e132e5f8fdb1"",
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
                    ""id"": ""3932fa6e-a64b-41ee-b49d-fe7c5c20df49"",
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
                    ""id"": ""357fe68b-d5a3-4e58-93c9-781137db59df"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys LR"",
                    ""id"": ""73ce8bfc-af7d-436c-bfb6-e58fd1c17e9c"",
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
                    ""id"": ""d47e153b-53d0-48de-8609-659072b72ea9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fd5091f5-402d-4960-bc7e-df57bab2b8fb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""LeanLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right Stick UD"",
                    ""id"": ""ee0eef1d-a8e5-4de0-bd03-9280d9fab961"",
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
                    ""id"": ""38b99356-8f98-451c-97fa-2bdd453eff7d"",
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
                    ""id"": ""f5e65d26-a746-4e89-b5f2-bd4697032214"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys UD"",
                    ""id"": ""7bee701f-5880-44ea-a914-90f82881d69a"",
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
                    ""id"": ""237373ae-3fcd-4e12-af88-20f289ee8eb1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c6bf73f6-c2e6-44ec-87ab-ff78bee6f485"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""TiltFB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7b42fb4a-94dc-41d5-9a6a-36a7e96736c1"",
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
                    ""id"": ""2916511b-5674-4eb0-b7cf-b932438f5f2f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Triggers"",
                    ""id"": ""f3984829-b895-433c-8468-244e86f152aa"",
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
                    ""id"": ""8f841e68-3e0d-41a7-8422-0b1b796c05eb"",
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
                    ""id"": ""a0cd8134-8b21-4c6b-b8e1-54bc71ec3e08"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard WS"",
                    ""id"": ""10623aa8-4167-4a73-8f6f-15568e482e3b"",
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
                    ""id"": ""fc7fa26f-570f-45c8-b545-59e8bf601781"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6db6a0f1-18b1-4e0d-80da-ead55919d879"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e82622b5-eb97-42e4-be42-a6982dbd0275"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pogo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0336e4b9-93fb-413e-a42a-6d853961400c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Hop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72ed5d80-0ae8-4b38-b7fd-1cd6f3824ae6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b803b87-2e66-4d20-ae80-860520ccc671"",
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
                    ""id"": ""976a9ff6-28b1-453a-a116-c4c577e7e4ee"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ResetRotPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick LR"",
                    ""id"": ""618d4a53-6a37-48ce-ab56-e84b02e0d924"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d8062c86-c2a6-4a82-b7ca-df6668613a08"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4a0a63ff-3954-4666-92c8-b6eb125966f7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f3638064-09eb-4df9-b043-6ea2be639142"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftWeight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3ba2a1a-c38f-4774-9b7a-a3d237be1858"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AirRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02ef8c4f-263d-4f58-bdda-077893ea3038"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AirMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fe42be7-c096-4bc4-8c1b-0b39c6ec5807"",
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
                    ""id"": ""22982e0e-afea-4bda-9874-e619e2250cfb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8d980a5-c566-4ac0-a394-07b1e525374c"",
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
                    ""id"": ""a2c67d04-8c1d-4575-a58d-d344a4c75969"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75ce905b-0a09-4458-94a2-849cce783f20"",
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
                    ""id"": ""fb822e65-f1eb-480f-9bfe-da9fd530ad23"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""JumpCancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""5e66032f-0420-439c-930a-9b46c086aea2"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""c93dc62c-0b19-43a8-ab2d-be4bcb3928f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""47a23cf2-7bfb-45d0-baa4-3082fcc36782"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c644de2f-a19d-4720-ae69-86cba8eec9f4"",
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
                    ""id"": ""c7feef5f-7f09-4bbc-9017-1f623ffe42a4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d1d1312-14ad-4a4a-9061-bbda4f407bd9"",
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
                    ""id"": ""cb1957c8-cb9f-4cc0-b28e-494779613226"",
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
                    ""id"": ""032919fd-7e93-4ca1-a76b-bd01ff651d2a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a44fa414-a33f-4691-9c2b-297a35836c6d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""dde1aab2-e0a6-46b4-a59d-352c7725e480"",
            ""actions"": [
                {
                    ""name"": ""ResetRotPos"",
                    ""type"": ""Button"",
                    ""id"": ""e0f7ca64-171d-4c7c-afcd-eac62bb57ea9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""14cc224b-fd2b-44d1-996a-f71bc77a9140"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ResetRotPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""K&M"",
            ""bindingGroup"": ""K&M"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
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
        m_Gameplay_TiltFB = m_Gameplay.FindAction("TiltFB", throwIfNotFound: true);
        m_Gameplay_Turn = m_Gameplay.FindAction("Turn", throwIfNotFound: true);
        m_Gameplay_ShiftWeight = m_Gameplay.FindAction("ShiftWeight", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Launch = m_Gameplay.FindAction("Launch", throwIfNotFound: true);
        m_Gameplay_AirMovement = m_Gameplay.FindAction("AirMovement", throwIfNotFound: true);
        m_Gameplay_AirRotation = m_Gameplay.FindAction("AirRotation", throwIfNotFound: true);
        m_Gameplay_Ping = m_Gameplay.FindAction("Ping", throwIfNotFound: true);
        m_Gameplay_JumpCancel = m_Gameplay.FindAction("JumpCancel", throwIfNotFound: true);
        m_Gameplay_Pogo = m_Gameplay.FindAction("Pogo", throwIfNotFound: true);
        m_Gameplay_Hop = m_Gameplay.FindAction("Hop", throwIfNotFound: true);
        m_Gameplay_Reset = m_Gameplay.FindAction("Reset", throwIfNotFound: true);
        m_Gameplay_ResetRotPos = m_Gameplay.FindAction("ResetRotPos", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_ResetRotPos = m_Debug.FindAction("ResetRotPos", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_TiltFB;
    private readonly InputAction m_Gameplay_Turn;
    private readonly InputAction m_Gameplay_ShiftWeight;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Launch;
    private readonly InputAction m_Gameplay_AirMovement;
    private readonly InputAction m_Gameplay_AirRotation;
    private readonly InputAction m_Gameplay_Ping;
    private readonly InputAction m_Gameplay_JumpCancel;
    private readonly InputAction m_Gameplay_Pogo;
    private readonly InputAction m_Gameplay_Hop;
    private readonly InputAction m_Gameplay_Reset;
    private readonly InputAction m_Gameplay_ResetRotPos;
    public struct GameplayActions
    {
        private @UnicycleController m_Wrapper;
        public GameplayActions(@UnicycleController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pedal => m_Wrapper.m_Gameplay_Pedal;
        public InputAction @LeanLR => m_Wrapper.m_Gameplay_LeanLR;
        public InputAction @TiltFB => m_Wrapper.m_Gameplay_TiltFB;
        public InputAction @Turn => m_Wrapper.m_Gameplay_Turn;
        public InputAction @ShiftWeight => m_Wrapper.m_Gameplay_ShiftWeight;
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        public InputAction @Launch => m_Wrapper.m_Gameplay_Launch;
        public InputAction @AirMovement => m_Wrapper.m_Gameplay_AirMovement;
        public InputAction @AirRotation => m_Wrapper.m_Gameplay_AirRotation;
        public InputAction @Ping => m_Wrapper.m_Gameplay_Ping;
        public InputAction @JumpCancel => m_Wrapper.m_Gameplay_JumpCancel;
        public InputAction @Pogo => m_Wrapper.m_Gameplay_Pogo;
        public InputAction @Hop => m_Wrapper.m_Gameplay_Hop;
        public InputAction @Reset => m_Wrapper.m_Gameplay_Reset;
        public InputAction @ResetRotPos => m_Wrapper.m_Gameplay_ResetRotPos;
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
                @TiltFB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @TiltFB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @TiltFB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTiltFB;
                @Turn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @ShiftWeight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @ShiftWeight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @ShiftWeight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShiftWeight;
                @Crouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                @Launch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @Launch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @Launch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaunch;
                @AirMovement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirMovement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirMovement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirMovement;
                @AirRotation.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @AirRotation.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @AirRotation.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAirRotation;
                @Ping.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
                @Ping.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
                @Ping.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPing;
                @JumpCancel.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @JumpCancel.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @JumpCancel.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpCancel;
                @Pogo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPogo;
                @Pogo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPogo;
                @Pogo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPogo;
                @Hop.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHop;
                @Hop.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHop;
                @Hop.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHop;
                @Reset.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReset;
                @ResetRotPos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnResetRotPos;
                @ResetRotPos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnResetRotPos;
                @ResetRotPos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnResetRotPos;
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
                @TiltFB.started += instance.OnTiltFB;
                @TiltFB.performed += instance.OnTiltFB;
                @TiltFB.canceled += instance.OnTiltFB;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @ShiftWeight.started += instance.OnShiftWeight;
                @ShiftWeight.performed += instance.OnShiftWeight;
                @ShiftWeight.canceled += instance.OnShiftWeight;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Launch.started += instance.OnLaunch;
                @Launch.performed += instance.OnLaunch;
                @Launch.canceled += instance.OnLaunch;
                @AirMovement.started += instance.OnAirMovement;
                @AirMovement.performed += instance.OnAirMovement;
                @AirMovement.canceled += instance.OnAirMovement;
                @AirRotation.started += instance.OnAirRotation;
                @AirRotation.performed += instance.OnAirRotation;
                @AirRotation.canceled += instance.OnAirRotation;
                @Ping.started += instance.OnPing;
                @Ping.performed += instance.OnPing;
                @Ping.canceled += instance.OnPing;
                @JumpCancel.started += instance.OnJumpCancel;
                @JumpCancel.performed += instance.OnJumpCancel;
                @JumpCancel.canceled += instance.OnJumpCancel;
                @Pogo.started += instance.OnPogo;
                @Pogo.performed += instance.OnPogo;
                @Pogo.canceled += instance.OnPogo;
                @Hop.started += instance.OnHop;
                @Hop.performed += instance.OnHop;
                @Hop.canceled += instance.OnHop;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @ResetRotPos.started += instance.OnResetRotPos;
                @ResetRotPos.performed += instance.OnResetRotPos;
                @ResetRotPos.canceled += instance.OnResetRotPos;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_Select;
    public struct UIActions
    {
        private @UnicycleController m_Wrapper;
        public UIActions(@UnicycleController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_ResetRotPos;
    public struct DebugActions
    {
        private @UnicycleController m_Wrapper;
        public DebugActions(@UnicycleController wrapper) { m_Wrapper = wrapper; }
        public InputAction @ResetRotPos => m_Wrapper.m_Debug_ResetRotPos;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @ResetRotPos.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnResetRotPos;
                @ResetRotPos.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnResetRotPos;
                @ResetRotPos.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnResetRotPos;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ResetRotPos.started += instance.OnResetRotPos;
                @ResetRotPos.performed += instance.OnResetRotPos;
                @ResetRotPos.canceled += instance.OnResetRotPos;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K&M");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnPedal(InputAction.CallbackContext context);
        void OnLeanLR(InputAction.CallbackContext context);
        void OnTiltFB(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnShiftWeight(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLaunch(InputAction.CallbackContext context);
        void OnAirMovement(InputAction.CallbackContext context);
        void OnAirRotation(InputAction.CallbackContext context);
        void OnPing(InputAction.CallbackContext context);
        void OnJumpCancel(InputAction.CallbackContext context);
        void OnPogo(InputAction.CallbackContext context);
        void OnHop(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnResetRotPos(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnResetRotPos(InputAction.CallbackContext context);
    }
}
