using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_AirControl : MonoBehaviour
{
    Scr_InputController _input;

    public Scr_GroundCheck _gc;

    Rigidbody _rb;

    public Rigidbody wheelRB;

    [Header("Define Variables")]

    [SerializeField] private float _rotTorqueFlip;
    [SerializeField] private float _rotPowerFlip = 175f;

    //[SerializeField] private float _rotTorqueRoll;
    //[SerializeField] private float _rotPowerRoll = 50f;

    [SerializeField] private float _moveForceFB;
    [SerializeField] private float _movePowerFB = 200f;

    [SerializeField] private float _moveForceLR;
    [SerializeField] private float _movePowerLR = 50f;

    [SerializeField] private float _turnForceLR;
    [SerializeField] private float _turnPowerLR = 50f;

    [SerializeField] private bool _isGrounded;

    [SerializeField] public float _airTimer;
    private float fallMultiplier;

    public bool airControls = false;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        fallMultiplier = 8f;
    }

    private void Update() {
        _isGrounded = _gc.isGrounded;

        if (!_isGrounded) {
            _airTimer++;

            _rotTorqueFlip = _input.AirborneRotationInput.y;
            //_rotTorqueRoll = _input.AirborneRotationInput.x;

            _moveForceFB = _input.AirborneMovementInput.y;
            _moveForceLR = _input.AirborneMovementInput.x;
            _turnForceLR = _input.AirborneMovementInput.x;
        } else { _airTimer = 0; }

        // If the unicycle is falling...
        if (_rb.velocity.y < 0f && !_isGrounded) {
            // The longer the unicyle is airborne, the faster it falls
            fallMultiplier += (_airTimer * 0.01f);
            // Increase gravity while unicycle falls to decrease 'floaty' feeling
            wheelRB.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            // Reset fall multiplier upon landing
        } else { fallMultiplier = 8f; }
    }

    private void FixedUpdate() {

        // Call inputs when airborne
        if (!_isGrounded) {

            if (_rb.velocity.y <= 0 && _airTimer >= 15) {
                airControls = true;

                wheelRB.AddForce(_rotTorqueFlip * _rotPowerFlip * _rb.transform.forward, ForceMode.Force);
                //_rb.AddTorque(_rotTorqueRoll * _rotPowerRoll * _rb.transform.forward, ForceMode.Force);

                wheelRB.AddForce(_moveForceFB * _movePowerFB * _rb.transform.forward, ForceMode.Acceleration);
                wheelRB.AddForce(_moveForceLR * _movePowerLR * _rb.transform.up, ForceMode.Acceleration);
                wheelRB.AddTorque(_turnForceLR * _turnPowerLR * _rb.transform.right, ForceMode.Force);
            } else { airControls = false; }
        }
    }
}
