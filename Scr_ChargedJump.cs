using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ChargedJump : MonoBehaviour
{
    [Header ("Get Components")]
    public GameObject _gc;

    Rigidbody _rb;

    public Rigidbody _wheelRB;

    [SerializeField] Rigidbody _forkRB;

    [Header ("Declare Inputs")]
    Scr_InputController _input;

    [SerializeField] private float _crouch;

    [SerializeField] private float _launch;
    [SerializeField] private float _cancel;

    [Header ("Declare Variables")]

    [SerializeField] public bool _onGround;
    [SerializeField] private bool _canJump;
    [SerializeField] private bool _shouldJump;
    [SerializeField] private float _airTimer;
    [SerializeField] private int _cancelTimer;
    [SerializeField] private float _jumpVelocity = 60f;

    public float _jumpPressure;

    [SerializeField] private float _minJump = .3f;
    [SerializeField] private float _maxJumpPressure = 1f;

    [Header ("Gravity Variables")]

    [SerializeField] private float fallMultiplier = 6f;

    private void Awake() {
        // Get rigidbody
        _rb = GetComponent<Rigidbody>();

        // Call input from input controller on Game Master
        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

    }

    void Start() {
        // set default 'jump pressure' to the minimum jump height when jump is tapped, not held
        _jumpPressure = _minJump;
    }

    private void Update() {
        // Increase gravity while unicycle falls to decrease 'floaty' feeling
        if (_rb.velocity.y < 0 && !_onGround) {
            _rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
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

        // call boolean for ground check from ground check script
        _onGround = _gc.GetComponent<Scr_GroundCheck>().isGrounded;

        // keep track of the time in which the unicycle is off the ground
        if (_onGround == false) {
            _airTimer++;
        } else if (_onGround == true) {
            _airTimer = 0f;
        }

        // if the unicycle is on the ground (or was just a frame or two ago), register as "can jump." The reason for this is that, while charging the jump, every single time the ground check would show false, the charge jump would reset. this leaves a 'grace period," so to speak.
        if (_airTimer <= 2f) {
            _canJump = true;
        } else {
            _canJump = false;
        }

        // if crouch button is held, and unicycle is grounded, the unicycle "should" jump
        if (_crouch == 1f && _canJump == true) {
            _shouldJump = true;
        }

        // if crouching...
        if (_shouldJump == true) {
            // set jump pressure maximum
            if (_jumpPressure >= _maxJumpPressure) {
                _jumpPressure = _maxJumpPressure;
            } else {
                // add ump pressure while 'crouch' is held (charge jump)
                _jumpPressure += .02f;
            }
        }

        if (_shouldJump == true /* && _onGround == true*/) {
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
        if (_shouldJump == true && _onGround != true) {
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
            if (_shouldJump == true) {
                _shouldJump = false;
                _canJump = false;
                _jumpPressure = _minJump;
            }
        } else { _cancelTimer = 0; }  
    }

    void Launch() {

        if (_shouldJump == true && _canJump == true) {
            _wheelRB.AddForce(_forkRB.transform.up * (_jumpPressure * _jumpVelocity), ForceMode.Impulse);
            _canJump = false;
            _shouldJump = false;
            _jumpPressure = _minJump;
            _crouch = 0f;

        } else {
            _canJump = false;
            _shouldJump = false;
            _jumpPressure = _minJump;
            _crouch = 0f;
        }
    }
}
