using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargedJump : MonoBehaviour
{
    public GameObject _gc;

    Rigidbody _rb;
    public Rigidbody _wheelRB;
   

    [SerializeField] Rigidbody _forkRB;

    UnicycleController _controls;

    [SerializeField] public bool _onGround;
    [SerializeField] private bool _canJump;
    [SerializeField] private bool _shouldJump;
    [SerializeField] private float _airTimer;
    [SerializeField] private float _jumpVelocity = 60f;

    public float _jumpPressure;

    private float _minJump = 50f;
    private float _maxJumpPressure = 200f;
 
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        _controls = new UnicycleController();

        _controls.Gameplay.Launch.performed += ctx => Launch();

        _controls.Gameplay.Crouch.performed += ctx => Crouch();

        _controls.Gameplay.JumpCancel.performed += ctx => JumpCancel();
    }

    void Start()
    {
        _jumpPressure = 10f;
    }

    private void FixedUpdate()
    {
        _onGround = _gc.GetComponent<Ground_Check>().isGrounded;

        if (_onGround == false)
        {
            _airTimer++;
        }
        else
        {
            _airTimer = 0f;
        }

        if (_airTimer <= 2f)
        {
            _shouldJump = true;
        }
        else
        {
            _shouldJump = false;
            _canJump = false;
        }

        if (_canJump == true)
        {
            if (_jumpPressure >= _maxJumpPressure)
            {
                _jumpPressure = _maxJumpPressure;
            }
            else
            {
                _jumpPressure += 1f;
            }
        }
        
    }

    void Crouch()
    {
        _canJump = true;
    }

    void JumpCancel()
    {
        _canJump = false;
        _jumpPressure = 10f;
    }

    void Launch()
    {
      
        if (_shouldJump == true && _canJump == true)
        {
            _wheelRB.AddForce(_forkRB.transform.up * ((_jumpPressure + _jumpVelocity) + _minJump), ForceMode.Impulse);

        }
        _canJump = false;
        _jumpPressure = 10f;

    }

    private void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
