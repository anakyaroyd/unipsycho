using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeControl_Fork : MonoBehaviour
{
    public HingeJoint _hinge;

    public JointMotor _motor;

    UnicycleController _controls;

    [Header("----- Input Modifiers -----")]

    [SerializeField] private float leanFB;
    [SerializeField] private float _tiltFBForce = 1000f;
    [SerializeField] private float _moForce;


    private void Awake()
    {
        _controls = new UnicycleController();

        _controls.Gameplay.TiltFB.performed += ctx => leanFB = ctx.ReadValue<float>();
        _controls.Gameplay.TiltFB.canceled += ctx => leanFB = ctx.ReadValue<float>();
    }
    void Start()
    {
        _hinge = GetComponent<HingeJoint>();

        // motor force is set to input from controls times force value set in inspector
       _moForce = leanFB * _tiltFBForce;

        // motor 
        _motor = _hinge.motor;
        _motor.force = 1000f;
        _motor.targetVelocity = 1000f;
        _motor.freeSpin = false;
        _hinge.motor = _motor;
        _hinge.useMotor = true;
    }

    void OnEnable() {
        _controls.Gameplay.Enable();
    }

    void OnDisable(){
        _controls.Gameplay.Disable();
    }
}
