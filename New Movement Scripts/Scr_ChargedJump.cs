using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ChargedJump : MonoBehaviour
{
    [Header ("Get Components")]

    private Rigidbody _rb;

    private Scr_GroundCheck _gc;

    private Scr_InputController _input;

    [SerializeField] private Rigidbody _wheelRB;

    [SerializeField] private Rigidbody _forkRB;

    [Header ("Declare Inputs")]

    private float _crouch;
    private float _launch;
    private float _cancel;

    [Header ("Declare Variables")]

    public bool _onGround;
    public bool shouldJump;
    private bool _canJump;

    private int _cancelTimer;

    public float jumpPressure;

    private float _jumpVelocity = 1000f;
    private float _airTimer;
    private float _minJump = .3f;
    private float _maxJumpPressure = 1f;

    private void Awake() {
        // Get rigidbody
        _rb = GetComponent<Rigidbody>();

        // Call input from input controller on Game Master
        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        // call boolean for ground check from ground check script
        _gc = GetComponentInChildren<Scr_GroundCheck>();
    }

    void Start() {
        // set default 'jump pressure' to the minimum jump height when jump is tapped, not held
        jumpPressure = _minJump;
    }

    private void Update() {

        // call boolean for ground check from ground check script
        _onGround = _gc.isGrounded;

        // keep track of the time in which the unicycle is off the ground
        if (_onGround == false) {
            _airTimer++;
        } else if (_onGround == true) {
            _airTimer = 0f;
        }

        // timer after JumpCancel is called
        if (_cancelTimer >= 5 && _cancelTimer < 0) {
            _cancelTimer--;
        }
    }

    private void FixedUpdate() {

        // call input from controller
        _launch = _input.LaunchInput;
        _crouch = _input.CrouchInput;
        _cancel = _input.JumpCancelInput;

        // if the unicycle is on the ground (or was just a frame or two ago), register as "can jump." The reason for this is that, while charging the jump, every single time the ground check would show false, the charge jump would reset. this leaves a 'grace period," so to speak.
        if (_airTimer <= 2f) {
            _canJump = true;
        } else {
            _canJump = false;
        }

        // if crouch button is held, and unicycle is grounded, the unicycle "should" jump
        if (_crouch == 1f && _canJump == true) {
            shouldJump = true;
        }

        // if crouching...
        if (shouldJump == true) {
            // set jump pressure maximum
            if (jumpPressure >= _maxJumpPressure) {
                jumpPressure = _maxJumpPressure;
            } else {
                // add ump pressure while 'crouch' is held (charge jump)
                jumpPressure += .02f;
            }
        }

        if (shouldJump == true /* && _onGround == true*/) {
            // if unicycle "should" jump, and player releases crouch, then launch uni
            if (_crouch == 0f) {
                Launch();
            }
            // if unicycle "should" jump, but player cancels jump, run JumpCancel method
            else if (_cancel != 0f) {
                JumpCancel();
            }
        }

        // if unicycle is in air, and player releases crouch, then run JumpCancel method
        if (shouldJump == true && _onGround != true) {
            if (_crouch == 0f) {
                JumpCancel();
            } else if (_cancel != 0f) {
                JumpCancel();
            }
        }
    }

    void JumpCancel() {

        _cancelTimer = 5;

        if (_cancelTimer > 0) {
            if (shouldJump == true) {
                shouldJump = false;
                _canJump = false;
                jumpPressure = _minJump;
            }
        } else { _cancelTimer = 0; }  
    }

    void Launch() {

        if (shouldJump == true && _canJump == true) {
            _wheelRB.AddForce(_forkRB.transform.up * (jumpPressure * _jumpVelocity), ForceMode.Impulse);
            _canJump = false;
            shouldJump = false;
            jumpPressure = _minJump;
            _crouch = 0f;

        } else {
            _canJump = false;
            shouldJump = false;
            jumpPressure = _minJump;
            _crouch = 0f;
        }
    }
}
