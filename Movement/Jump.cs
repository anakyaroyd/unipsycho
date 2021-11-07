using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    UnicycleController _controls;

    public GameObject gc;
    public Rigidbody _forkRB;
    public Rigidbody _wheelRB;

    [SerializeField] public bool _canJump;

    [SerializeField] private bool _onGround;
    [SerializeField] private bool _shouldJump;

    [SerializeField] private float _jumpPressure;
    [SerializeField] private float _jumpForce = 90000f;

    [SerializeField] private float _minJump = 60000f;
    [SerializeField] private float _maxJumpPressure = 600000f;


    public float _groundTimer;


    private void Awake()
    { 
        _controls = new UnicycleController();

        _controls.Gameplay.Launch.performed += ctx => Launch();
        _controls.Gameplay.Crouch.performed += ctx => Crouch();
        //_controls.Gameplay.Hop.performed += ctx => Hop();
    }

    void Start()
    {
        //_jumpPressure = 0f;
        //_jumpForce = 90000f;
        //_minJump = 60000f;
        //_maxJumpPressure = 600000f;


    }

    void Update()
    {
        _onGround = gc.GetComponent<Ground_Check>().isGrounded;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_onGround != true)
        {
            _groundTimer++;
        }
        else
        {
            _groundTimer = 0f;
        }

        if (_canJump == true)
        {
            if (_jumpPressure < _maxJumpPressure)
            {

                _jumpPressure += _jumpForce * Time.deltaTime;

            }
            else { _jumpPressure = _maxJumpPressure; }
        }
    }

    void Crouch()
    {
        if (_groundTimer < 10f)
        {
            _canJump = true;

        }
        else
        {
            _canJump = false;
        }

    }

    void Launch()
    {

        if (_canJump == true)
        {
            _wheelRB.AddForce((_jumpPressure += _minJump) * _forkRB.transform.up * Time.deltaTime);
        }

        _canJump = false;
        _jumpPressure = 0f;
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
