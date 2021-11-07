using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class Jump_Script : MonoBehaviour
{
    [Header("Initiate Components")]

    private Rigidbody _rigidbody;
    UnicycleController _controls;

    public GameObject _groundCheck;
    public Rigidbody _forkRB;

    [Header("Jump Inputs")]

    [SerializeField] private float _jumpForce = 60000f;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private float _groundedTimer;
    [SerializeField] private float _launchTimer;
    [SerializeField] private float _fullCharge = 20f;

    private bool _shouldJump;
    // private bool _launch;
    // private float _crouch;
    //private bool _crouched;
    //
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _launchTimer = 0f;
        _groundedTimer = 0f;

        _controls = new UnicycleController();

        _controls.Gameplay.Crouch.started += ctx => Crouch();
        _controls.Gameplay.Launch.performed += ctx => Launch();

        Mathf.Clamp(_launchTimer, 0, 20f);

    }

    private void Update()
    {
   
    }

    private void FixedUpdate()
    {
        _isGrounded = _groundCheck.GetComponent<Ground_Check>().isGrounded;

        if (_isGrounded == false){
            _groundedTimer++;
        }
        else
        {
            _groundedTimer = 0f;
        }

        if (_shouldJump == true && _launchTimer < _fullCharge)
        {
            _launchTimer++;

        }

    }

    private void Crouch()
    {
        _shouldJump = true;

    }

    private void Launch()
    {
        if (_groundedTimer < 10f)
        {
            _rigidbody.AddForce((_jumpForce * (1f + (.01f * _launchTimer))) * _forkRB.transform.up * Time.deltaTime);  
           // _rigidbody.AddForce((_jumpForce * (1f + (.01f * _launchTimer))) * _forkRB.transform.up * Time.deltaTime);  
        }

        _shouldJump = false;
        _launchTimer = 0f;
    }

    void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
