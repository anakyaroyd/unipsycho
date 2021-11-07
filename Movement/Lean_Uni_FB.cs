using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean_Uni_FB : MonoBehaviour
{
    //public Rigidbody _rb;

    //UnicycleController _controls;

    //[SerializeField] private float _leanUniFB;
    //[SerializeField] private float _leanAngle;
    //// [SerializeField] private float _tiltLRForce = 25f;

    //private void Awake()
    //{
    //    _rb = GetComponent<Rigidbody>();

    //    _controls = new UnicycleController();

    //    _controls.Gameplay.LeanUniFB.performed += ctx => _leanUniFB = ctx.ReadValue<float>();
    //    _controls.Gameplay.LeanUniFB.canceled += ctx => _leanUniFB = ctx.ReadValue<float>();

    //}

    //private void FixedUpdate()
    //{
    //    _leanAngle = (Mathf.Abs(_rb.transform.rotation.z) + .2f) * 70f;

    //    _rb.AddTorque((_leanAngle * _leanUniFB) * -_rb.transform.right);

    //}

    //private void OnEnable()
    //{
    //    _controls.Gameplay.Enable();
    //}

    //private void OnDisable()
    //{
    //    _controls.Gameplay.Disable();
    //}
}