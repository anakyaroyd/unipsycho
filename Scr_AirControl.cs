using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_AirControl : MonoBehaviour
{
    Scr_InputController _input;

    Scr_GroundCheck _gc;

    Rigidbody _rb;

    public Rigidbody forkRB;

    [Header("Define Variables")]

    [SerializeField] private float _rotTorqueFlip;
    [SerializeField] private float _rotPowerFlip = 175f;

    //[SerializeField] private float _rotTorqueRoll;
    //[SerializeField] private float _rotPowerRoll = 50f;

    [SerializeField] private float _moveForceFB;
    [SerializeField] private float _movePowerFB = 200f;

    [SerializeField] private float _moveForceLR;
    [SerializeField] private float _movePowerLR = 50f;

    [SerializeField] private bool _isGrounded;

    [SerializeField] private int _airTimer;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _gc = GetComponentInChildren<Scr_GroundCheck>();
    }

    private void Update() {
        _isGrounded = _gc.isGrounded;

        if (!_isGrounded) {
            _airTimer++;

            _rotTorqueFlip = _input.AirborneRotationInput.y;
            //_rotTorqueRoll = _input.AirborneRotationInput.x;

            _moveForceFB = _input.AirborneMovementInput.y;
            _moveForceLR = _input.AirborneMovementInput.x;
        } else { _airTimer = 0; }
    }

    private void FixedUpdate() {

        // Call inputs when airborne
        if (!_isGrounded) {

            if (_rb.velocity.y <= 2f && _airTimer >= 15) {

                forkRB.AddForce(_rotTorqueFlip * _rotPowerFlip * forkRB.transform.forward, ForceMode.Force);
                //_rb.AddTorque(_rotTorqueRoll * _rotPowerRoll * _rb.transform.forward, ForceMode.Force);


                _rb.AddForce(_moveForceFB * _movePowerFB * _rb.transform.forward, ForceMode.Acceleration);
                _rb.AddTorque(_moveForceLR * _movePowerLR * _rb.transform.up, ForceMode.Force);
            }
        }
    }
}
