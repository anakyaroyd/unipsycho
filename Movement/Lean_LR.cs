using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean_LR : MonoBehaviour
{
    public Rigidbody _rb;

    Scr_InputController _input;

    [SerializeField] private float _leanLR;
    [SerializeField] private float _leanAngle;
    [SerializeField] private float _leanPower;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

    }

    private void Update() {
        _leanLR = _input.LeanLRInput;

        _leanAngle = (Mathf.Abs(_rb.transform.rotation.z) + .05f) * _leanPower;
    }

    private void FixedUpdate() { 
        _rb.AddTorque((_leanAngle * _leanLR) * -_rb.transform.forward);
    }
}
