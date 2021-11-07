using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Scr_CameraFollowReversingUni : MonoBehaviour
{
    [Header ("Define Cameras")]
    [SerializeField] private CinemachineVirtualCamera camNear;
    [SerializeField] private CinemachineVirtualCamera camReverse;

    [Header ("Define Input and Input Values")]
    Scr_InputController input;

    public float PedalInput { get; set; }

    [SerializeField] private float _pedalInput;

    void Awake()
    {
            // Call Input Controller
        input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

            // Establish default camera
        camNear.enabled = true;
        camReverse.enabled = false;
    }

    private void Update() {
            // Call pedal input from Game Master
        _pedalInput = input.PedalInput;
    }
   
    void LateUpdate() {
            // Initialize function based on pedal value
        if(_pedalInput < 0f) {
            Reversing();
        }
        else {
            ForwardPedal();
        }
    }

    void Reversing() {
            // Set reversing camera active
        camNear.enabled = false;
        camReverse.enabled = true;
    }

    void ForwardPedal() {
            // Set forward camera active
        camNear.enabled = true;
        camReverse.enabled = false;
    }
}
