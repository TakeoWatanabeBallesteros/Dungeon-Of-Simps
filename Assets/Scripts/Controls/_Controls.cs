// GENERATED AUTOMATICALLY FROM 'Assets/Input/_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""_Controls"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""65cef8d1-6557-420b-8609-e7c65665f920"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a6a618d5-c845-4dc3-b1b2-5699f8e75009"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""8a2e4d41-a89c-4894-b18d-1b2fa9b0e6ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""MouseAim"",
                    ""type"": ""Value"",
                    ""id"": ""924b0171-c3a1-4b63-ade7-7e6fa1e0a9c6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""3d4a6d3d-ce47-4560-bca9-3a83cb8c2168"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""9822097e-8db0-4dd1-baba-6b31c697129c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlowMotion"",
                    ""type"": ""Button"",
                    ""id"": ""0eb417e0-4125-487f-86dd-6195508058a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TogglePause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69eb7303-c430-4ec7-8b3e-0fa0cad8551d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SwitchGun"",
                    ""type"": ""PassThrough"",
                    ""id"": ""877c8bfd-3ec8-4074-8711-45de9b8a29a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Health"",
                    ""type"": ""Button"",
                    ""id"": ""4eb84dcd-3cc9-480a-9b34-7b3a838215ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""446888ec-96d8-4a6a-a2ed-89245f1fb1b8"",
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
                    ""id"": ""1ddb2de7-48b6-4504-9ec6-11df8ae928e7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""70f08808-81f3-4140-adde-f3d78219b916"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a463246-4ca0-4230-8dea-6923817b5c9b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f185531-1703-470c-a05d-b208769e1fe1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""62795db1-c2d3-4905-ab2f-c8d72b69ae27"",
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
                    ""id"": ""a28203ae-3aa1-4651-b340-1b0a3e986c52"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""35de9c38-510e-450a-89d7-6e08621ed3c7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0b4ee86e-9142-46e3-8680-ab92dd069e8e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f0d2f2e-12a7-4fc5-9508-ad129495cd0f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e0a61ca3-e817-4967-aef1-424378972032"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72fda339-fa25-424c-9b3a-3a4cbc306aa5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1219ca9f-5cf9-453c-bec6-e843286cd4fd"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99dff7c1-ef5b-4519-8a8c-6a1dce9a3d61"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b9fce90-f345-4733-a5b7-ba9c0222c675"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd43898d-e27a-4fb6-b738-33d27ad90da1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c2bc4f-1f48-41fb-99d2-d589f8c53e37"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebc3b67c-154c-4f16-9abd-96319a3b108a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e82a9b2-9476-449f-9719-49de03ec82bb"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9525a122-2e68-4fb9-92d0-4d4682efd004"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowMotion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf18c2ee-c478-4f67-9823-ca22e0da4890"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SlowMotion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""147879b8-3e2f-45bb-a915-0988e7b64189"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a20fda6-cf36-4993-9083-89289c0c2f08"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a850b0ab-dfc7-4a16-beee-415997a0df88"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SwitchGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""238eb1cb-5f4e-4762-aee9-e247d2425beb"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Health"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb5f1a6c-8c3d-4ab7-856e-38f44e6768e4"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Health"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Controls"",
            ""id"": ""6a92837e-9c8e-48f8-9149-f3ac6489bbbd"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f258ead-c9f7-4b84-8d83-3f736e8ab14c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0d4cfe48-dd35-448f-bc3c-b49497f286cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8599fab6-67b6-457d-a60c-b0b46bc08bf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae85a4b0-067b-43dc-a4ed-355bf97d8ac5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""128b3e98-1ea1-4c3f-b5f4-677f22c01f76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""719bb82d-d2c0-4743-9690-e9fdd8f60ca7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""de3759fb-eb85-49e2-b9a8-5d7aeb48e064"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c2008a76-e7df-4e93-8018-90f1cf59d993"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66ef7018-ea8d-4e67-a30a-50b9bb160fcb"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ee2ffef-96cc-4455-a215-0f30187de69a"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TogglePause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cc6a22f3-2431-41b9-bb9c-23ddab0bab51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""e059f1af-9705-4cfa-b687-e33151d2878b"",
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
                    ""id"": ""847a5d60-353d-43b9-88a7-e7c0d5ae50be"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fffc1bb5-d393-49fc-8f1d-3f2bc7005e15"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5c51f1dc-6185-4905-a2e4-ae3efce6b73c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1537d574-49de-489b-aa4d-105160c10a35"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""512722e0-ed0a-4325-adf1-a368a5691e40"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9041debf-9b67-4876-8b3e-7b2b3097c89f"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""80b64002-547a-4e4c-b749-31ebc6d33c7f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""75ab99cf-a8e5-4ead-96e3-5be01cb3d53b"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""985e31d3-f6d3-49e8-8055-693efb06824e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""d8629ea8-4004-4131-9d73-1e2564e753da"",
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
                    ""id"": ""ebdb9aef-67fc-4beb-b277-060c8210fc05"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""09ed641a-f801-48f9-a363-faa03ae8a8ce"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""27ca3a92-61b4-40c2-83fd-8246c5401794"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b705152-a109-4b47-9a69-7adde7d31a86"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""1919bc9c-f6b9-4622-bbdc-2694758ec22c"",
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
                    ""id"": ""e2cf8170-a5e8-4d60-90d4-b839126a8246"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""06793a4a-1192-4b50-8ffb-d6353eb127a7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cb28bfa2-a227-4322-8bdf-8f1d3574fc6d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9e1e3c58-f74b-4bac-be01-d801c9d39921"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c3a1bf4b-254b-4f4c-aaec-d725eed10e75"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f2e39bd9-b530-45b2-b632-d7c85dcfbe92"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""66ccd4c6-5081-43b5-b03a-a864f9a15a5f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c31cd9ae-42e6-4cf7-9a5b-5e53366549df"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""04cacbeb-8b54-4297-9dcb-214178d05d56"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7698e2d2-2802-4529-a2b5-ef5ae916e2f9"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""777ac620-4daf-44b4-9dd7-368512708a7d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a633d09-6225-47a9-bbfc-8b85bfaa1049"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e36655b-5c2f-440f-9102-f1d2ac746bde"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""362dad61-0a31-4878-b7c5-13edec095dd6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4930dc1b-49fd-4148-a114-7dfae5677862"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b363bf7-8f41-4efa-a688-08e7f64daf3a"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f189b8-30de-4dc4-996b-d7da608d66b5"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e9df788-099b-4ebd-93b0-250df363985a"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba88aab7-94bf-47e5-86cb-8e1d3492c95b"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5a26bcc-ba11-44a5-b41d-c29dcf367f31"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5d06fa5-c5c8-4b64-833e-b77a9cfe2502"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96cef1e9-345d-410c-8bc9-b99d39b3855f"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec77c82b-e02b-45c9-983f-b97ccf8fa36a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6cf2651-3bc6-42b0-908b-02a7211fc9ca"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Main Menu Controls"",
            ""id"": ""86d827c9-bd6c-417f-b1a0-6d85bbabc33c"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""41c1a3ff-a13d-4807-8eb4-1eebee25605e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aedfee9f-ea87-429f-8e68-ff1a39091e49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""98bb5528-d196-4c83-8662-a8cd881a948e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e707b636-c007-47f4-825e-bebbee6250e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a3eee3c7-9693-4cee-9572-192f95f5dc1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e415e1f3-2f34-4bfb-ad5f-5bfb58571ade"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b510f853-2b49-4eb7-b0ba-3d9bc4a302ba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da99134b-0926-4bde-8ee2-465ccc1d5d1a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66b82437-3e56-4ab4-9a87-22908a15ab13"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""49d900d4-6942-47fe-870c-908201afa686"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""6a502227-dfec-4971-a3d2-8ecf2ab722c1"",
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
                    ""id"": ""5e791aff-b152-47a6-88ae-11fab2fcd4ba"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ce23c1ff-b213-42e7-9eb5-18d343f66891"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd0280e8-b4c4-4f57-a201-b11fc364406c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e2a93288-936f-4a51-9b9e-6580552ccf80"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7aab33ab-8a3d-4529-9c6f-147dc3be16bd"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""055fa3ce-5b4c-408c-951d-e5db54c6f9c4"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87a20a83-f2f1-4191-b0c7-04d0de8ff345"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6a0ed06e-2742-446b-b6f8-23d47d01afd6"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f91e25e-077b-401e-acc8-d0d06174d979"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""c2579828-295f-444b-a8af-746895212913"",
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
                    ""id"": ""fb74d87a-8728-4f28-90df-d6d46c9fd821"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8304a1f0-4ce1-4ce6-a894-a5beb3539194"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""041ad3fe-b05e-4cbd-9eb9-bb530dfb7e44"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""74d4620a-4bbc-477d-8210-4bbb619c2e74"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5052311d-6921-4353-b2f6-2e91e063134f"",
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
                    ""id"": ""69594a27-732f-47f8-a503-233cad65b70c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6a1529ba-691b-4efc-94a8-cd9b6016830d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6102e73a-9844-40af-a869-04af8838181b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47e3de9f-22cb-4a7d-9352-ccc973911634"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d10edce-fc66-4ae4-97ac-3d68b56e009a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""68a01e67-db6b-41d2-8e84-3dfa88f5b225"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7ca76b70-01ee-4318-9c6c-ef9af16fe780"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b6eee979-a314-45d7-b619-aa5efa26c978"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""62a63d34-6690-4a7c-b5b7-31715f6af277"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c9a5724-bbf9-449e-b5a4-46b72206a9a8"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c02ffc1b-b586-4258-aa0b-c5cf6b667924"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""662e6db7-d184-4d19-8084-9dd04a335e55"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3007be9-7739-439c-b9a1-3c802f0c0ed4"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ae736fa-426f-4ca1-9d12-2afca969a7d5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""891b4038-d8a3-4ef6-bb46-8142f2773387"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52d228e4-df74-449d-916f-2587ae3fd14a"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae3b9542-122a-47b3-b49d-5a084d3dc468"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10371adb-01b5-46d5-b8dd-ab9d268725d4"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43b0370b-3780-41c5-a8be-bf6d50237b8d"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9246941-f55c-4edd-8f75-39139d3a9aa7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d1214ec-5e75-463f-b4a6-a1adc3e15dc3"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8d2e7c9-cb5a-4ca6-8ff9-c3915e472c32"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory Controls"",
            ""id"": ""0986eaa5-187f-415a-a1a1-c17288615c2e"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<WebGLGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_Fire1 = m_PlayerControls.FindAction("Fire1", throwIfNotFound: true);
        m_PlayerControls_MouseAim = m_PlayerControls.FindAction("MouseAim", throwIfNotFound: true);
        m_PlayerControls_Use = m_PlayerControls.FindAction("Use", throwIfNotFound: true);
        m_PlayerControls_Dash = m_PlayerControls.FindAction("Dash", throwIfNotFound: true);
        m_PlayerControls_SlowMotion = m_PlayerControls.FindAction("SlowMotion", throwIfNotFound: true);
        m_PlayerControls_TogglePause = m_PlayerControls.FindAction("TogglePause", throwIfNotFound: true);
        m_PlayerControls_SwitchGun = m_PlayerControls.FindAction("SwitchGun", throwIfNotFound: true);
        m_PlayerControls_Health = m_PlayerControls.FindAction("Health", throwIfNotFound: true);
        // Menu Controls
        m_MenuControls = asset.FindActionMap("Menu Controls", throwIfNotFound: true);
        m_MenuControls_Navigate = m_MenuControls.FindAction("Navigate", throwIfNotFound: true);
        m_MenuControls_Submit = m_MenuControls.FindAction("Submit", throwIfNotFound: true);
        m_MenuControls_Cancel = m_MenuControls.FindAction("Cancel", throwIfNotFound: true);
        m_MenuControls_Point = m_MenuControls.FindAction("Point", throwIfNotFound: true);
        m_MenuControls_Click = m_MenuControls.FindAction("Click", throwIfNotFound: true);
        m_MenuControls_ScrollWheel = m_MenuControls.FindAction("ScrollWheel", throwIfNotFound: true);
        m_MenuControls_MiddleClick = m_MenuControls.FindAction("MiddleClick", throwIfNotFound: true);
        m_MenuControls_RightClick = m_MenuControls.FindAction("RightClick", throwIfNotFound: true);
        m_MenuControls_TrackedDevicePosition = m_MenuControls.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_MenuControls_TrackedDeviceOrientation = m_MenuControls.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_MenuControls_TogglePause = m_MenuControls.FindAction("TogglePause", throwIfNotFound: true);
        // Main Menu Controls
        m_MainMenuControls = asset.FindActionMap("Main Menu Controls", throwIfNotFound: true);
        m_MainMenuControls_Navigate = m_MainMenuControls.FindAction("Navigate", throwIfNotFound: true);
        m_MainMenuControls_Submit = m_MainMenuControls.FindAction("Submit", throwIfNotFound: true);
        m_MainMenuControls_Cancel = m_MainMenuControls.FindAction("Cancel", throwIfNotFound: true);
        m_MainMenuControls_Point = m_MainMenuControls.FindAction("Point", throwIfNotFound: true);
        m_MainMenuControls_Click = m_MainMenuControls.FindAction("Click", throwIfNotFound: true);
        m_MainMenuControls_ScrollWheel = m_MainMenuControls.FindAction("ScrollWheel", throwIfNotFound: true);
        m_MainMenuControls_MiddleClick = m_MainMenuControls.FindAction("MiddleClick", throwIfNotFound: true);
        m_MainMenuControls_RightClick = m_MainMenuControls.FindAction("RightClick", throwIfNotFound: true);
        m_MainMenuControls_TrackedDevicePosition = m_MainMenuControls.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_MainMenuControls_TrackedDeviceOrientation = m_MainMenuControls.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // Inventory Controls
        m_InventoryControls = asset.FindActionMap("Inventory Controls", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_Fire1;
    private readonly InputAction m_PlayerControls_MouseAim;
    private readonly InputAction m_PlayerControls_Use;
    private readonly InputAction m_PlayerControls_Dash;
    private readonly InputAction m_PlayerControls_SlowMotion;
    private readonly InputAction m_PlayerControls_TogglePause;
    private readonly InputAction m_PlayerControls_SwitchGun;
    private readonly InputAction m_PlayerControls_Health;
    public struct PlayerControlsActions
    {
        private @_Controls m_Wrapper;
        public PlayerControlsActions(@_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @Fire1 => m_Wrapper.m_PlayerControls_Fire1;
        public InputAction @MouseAim => m_Wrapper.m_PlayerControls_MouseAim;
        public InputAction @Use => m_Wrapper.m_PlayerControls_Use;
        public InputAction @Dash => m_Wrapper.m_PlayerControls_Dash;
        public InputAction @SlowMotion => m_Wrapper.m_PlayerControls_SlowMotion;
        public InputAction @TogglePause => m_Wrapper.m_PlayerControls_TogglePause;
        public InputAction @SwitchGun => m_Wrapper.m_PlayerControls_SwitchGun;
        public InputAction @Health => m_Wrapper.m_PlayerControls_Health;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Fire1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire1;
                @Fire1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire1;
                @Fire1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire1;
                @MouseAim.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseAim;
                @MouseAim.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseAim;
                @MouseAim.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseAim;
                @Use.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
                @Dash.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @SlowMotion.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSlowMotion;
                @SlowMotion.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSlowMotion;
                @SlowMotion.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSlowMotion;
                @TogglePause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTogglePause;
                @SwitchGun.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchGun;
                @SwitchGun.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchGun;
                @SwitchGun.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchGun;
                @Health.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHealth;
                @Health.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHealth;
                @Health.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHealth;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @MouseAim.started += instance.OnMouseAim;
                @MouseAim.performed += instance.OnMouseAim;
                @MouseAim.canceled += instance.OnMouseAim;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @SlowMotion.started += instance.OnSlowMotion;
                @SlowMotion.performed += instance.OnSlowMotion;
                @SlowMotion.canceled += instance.OnSlowMotion;
                @TogglePause.started += instance.OnTogglePause;
                @TogglePause.performed += instance.OnTogglePause;
                @TogglePause.canceled += instance.OnTogglePause;
                @SwitchGun.started += instance.OnSwitchGun;
                @SwitchGun.performed += instance.OnSwitchGun;
                @SwitchGun.canceled += instance.OnSwitchGun;
                @Health.started += instance.OnHealth;
                @Health.performed += instance.OnHealth;
                @Health.canceled += instance.OnHealth;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Menu Controls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_Navigate;
    private readonly InputAction m_MenuControls_Submit;
    private readonly InputAction m_MenuControls_Cancel;
    private readonly InputAction m_MenuControls_Point;
    private readonly InputAction m_MenuControls_Click;
    private readonly InputAction m_MenuControls_ScrollWheel;
    private readonly InputAction m_MenuControls_MiddleClick;
    private readonly InputAction m_MenuControls_RightClick;
    private readonly InputAction m_MenuControls_TrackedDevicePosition;
    private readonly InputAction m_MenuControls_TrackedDeviceOrientation;
    private readonly InputAction m_MenuControls_TogglePause;
    public struct MenuControlsActions
    {
        private @_Controls m_Wrapper;
        public MenuControlsActions(@_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_MenuControls_Navigate;
        public InputAction @Submit => m_Wrapper.m_MenuControls_Submit;
        public InputAction @Cancel => m_Wrapper.m_MenuControls_Cancel;
        public InputAction @Point => m_Wrapper.m_MenuControls_Point;
        public InputAction @Click => m_Wrapper.m_MenuControls_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_MenuControls_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_MenuControls_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_MenuControls_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_MenuControls_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_MenuControls_TrackedDeviceOrientation;
        public InputAction @TogglePause => m_Wrapper.m_MenuControls_TogglePause;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TogglePause.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTogglePause;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @TogglePause.started += instance.OnTogglePause;
                @TogglePause.performed += instance.OnTogglePause;
                @TogglePause.canceled += instance.OnTogglePause;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);

    // Main Menu Controls
    private readonly InputActionMap m_MainMenuControls;
    private IMainMenuControlsActions m_MainMenuControlsActionsCallbackInterface;
    private readonly InputAction m_MainMenuControls_Navigate;
    private readonly InputAction m_MainMenuControls_Submit;
    private readonly InputAction m_MainMenuControls_Cancel;
    private readonly InputAction m_MainMenuControls_Point;
    private readonly InputAction m_MainMenuControls_Click;
    private readonly InputAction m_MainMenuControls_ScrollWheel;
    private readonly InputAction m_MainMenuControls_MiddleClick;
    private readonly InputAction m_MainMenuControls_RightClick;
    private readonly InputAction m_MainMenuControls_TrackedDevicePosition;
    private readonly InputAction m_MainMenuControls_TrackedDeviceOrientation;
    public struct MainMenuControlsActions
    {
        private @_Controls m_Wrapper;
        public MainMenuControlsActions(@_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_MainMenuControls_Navigate;
        public InputAction @Submit => m_Wrapper.m_MainMenuControls_Submit;
        public InputAction @Cancel => m_Wrapper.m_MainMenuControls_Cancel;
        public InputAction @Point => m_Wrapper.m_MainMenuControls_Point;
        public InputAction @Click => m_Wrapper.m_MainMenuControls_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_MainMenuControls_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_MainMenuControls_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_MainMenuControls_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_MainMenuControls_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_MainMenuControls_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_MainMenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuControlsActions instance)
        {
            if (m_Wrapper.m_MainMenuControlsActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_MainMenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_MainMenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public MainMenuControlsActions @MainMenuControls => new MainMenuControlsActions(this);

    // Inventory Controls
    private readonly InputActionMap m_InventoryControls;
    private IInventoryControlsActions m_InventoryControlsActionsCallbackInterface;
    public struct InventoryControlsActions
    {
        private @_Controls m_Wrapper;
        public InventoryControlsActions(@_Controls wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_InventoryControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryControlsActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryControlsActions instance)
        {
            if (m_Wrapper.m_InventoryControlsActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_InventoryControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public InventoryControlsActions @InventoryControls => new InventoryControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFire1(InputAction.CallbackContext context);
        void OnMouseAim(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnSlowMotion(InputAction.CallbackContext context);
        void OnTogglePause(InputAction.CallbackContext context);
        void OnSwitchGun(InputAction.CallbackContext context);
        void OnHealth(InputAction.CallbackContext context);
    }
    public interface IMenuControlsActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnTogglePause(InputAction.CallbackContext context);
    }
    public interface IMainMenuControlsActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface IInventoryControlsActions
    {
    }
}
