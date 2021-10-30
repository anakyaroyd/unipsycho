using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Fork : MonoBehaviour
{
     // Get Components
    Rigidbody _rb;

    Scr_InputController input;

    HingeJoint _hinge;
    JointSpring _spring;

    [Header("Define Variables")]

    [SerializeField] private float _tiltFBInput;
    [SerializeField] private float _tiltFBPush;
    [SerializeField] private float _springTarget;


    private void Awake() {
        input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _hinge = GetComponent<HingeJoint>();
        
    }

    private void Update() {
        _tiltFBInput = input.TiltFBInput;
        _spring = _hinge.spring;

            // Spring target position sets the angle of the fork 
        _springTarget = (_tiltFBInput * 50f);
        _spring.targetPosition = _springTarget;

        _hinge.spring = _spring;
    }
}
