using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Fork : MonoBehaviour {
    // Get Components
    Rigidbody _rb;

    Scr_InputController input;

    Scr_AirControl ac;

    HingeJoint _hinge;
    JointSpring _spring;

    [Header("Define Variables")]

    [SerializeField] private float _tiltFBInput;
    [SerializeField] private float _tiltFBPush;
    [SerializeField] private float _springTarget;

    private void Awake() {
        input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
        ac = GetComponent<Scr_AirControl>();
        _hinge = GetComponent<HingeJoint>();
    }

    private void FixedUpdate() {
        _tiltFBInput = input.TiltFBInput;

        _spring = _hinge.spring;

        // Spring target position sets the angle of the fork back to target angle (zero)
        _springTarget = (_tiltFBInput * 50f);
        _spring.targetPosition = _springTarget;
        _hinge.spring = _spring; 
    }
}

// Break hinge joint when unicycle falls from hieght - "missing hinge joint you are trying to reference"
// not working when i commented it out - just reset scene, didn't let the uni bust apart like i hoped

//if (_hinge == null) {
//    new WaitForSeconds(5);
//    input.ResetUni();
//    return;
//} else if (_hinge != null) {
//    _spring = _hinge.spring;
//    // Spring target position sets the angle of the fork 
//    _springTarget = (_tiltFBInput * 50f);
//    _spring.targetPosition = _springTarget;
//    _hinge.spring = _spring;

//if (ac._airTimer > 100f) {
//    _hinge.breakForce = 50;
//    _hinge.breakTorque = 50;
//}