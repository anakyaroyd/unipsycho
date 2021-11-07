using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fork_Control : MonoBehaviour
{
    public Rigidbody _rb;

    UnicycleController _controls;

    public HingeJoint _hinge;
    public JointSpring _spring;

    public float _springForce;
    
    [Header("----- Input Modifiers -----")]

    [SerializeField] private float leanFB;
    [SerializeField] private float leanFBMouse;
    [SerializeField] private float _tiltFBPush;
    [SerializeField] private float _tiltFBForce;
    [SerializeField] private float _sprTarget;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        _hinge = GetComponent<HingeJoint>();
        _spring = _hinge.spring;

        _controls = new UnicycleController();

        _controls.Gameplay.TiltFB.performed += ctx => leanFB = ctx.ReadValue<float>();
        _controls.Gameplay.TiltFB.canceled += ctx => leanFB = ctx.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        _spring = _hinge.spring;

        _tiltFBPush = (leanFB * 50f);

        _spring.targetPosition = -_tiltFBPush;

        _hinge.spring = _spring;


        #region // Spring engages when no input on joystick & LeanFBMouse w AddTorque
        //if (leanFBMouse < .2 && leanFBMouse > -.2)
        //{
        //    _spring.spring = _springForce;
        //}
        //else
        //{
        //    _spring.targetPosition = _tiltFBPush;
        //    _spring.spring = 400f;
        //}
        //#endregion

        //#region // LeanFBMouse with AddTorque (Before using Target Position

        //_rb.AddTorque((_tiltFBForce * leanFBMouse) * _rb.transform.right);

        #endregion 

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