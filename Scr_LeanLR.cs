using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_LeanLR : MonoBehaviour
{
    public Rigidbody _rb;

    Scr_InputController _input;

    [SerializeField] private float _leanLR;
    [SerializeField] private float _leanAngle;
    [SerializeField] private float _leanPower = 450f;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
    }

    private void FixedUpdate() {
        _leanLR = _input.LeanLRInput;

        _leanAngle = (Mathf.Abs(_rb.transform.rotation.z) + .05f) * _leanPower;

        _rb.AddTorque((_leanAngle * _leanLR) * -_rb.transform.forward);

            // Add more power if angle gets more extreme... didn't have the results I was hoping for.
        //if (_rb.transform.rotation.z > 50f || _rb.transform.rotation.z < -50f) {
        //    _rb.AddTorque(((_leanAngle * 2.5f) * _leanLR) * -_rb.transform.forward);
        //} else {
        //    _rb.AddTorque((_leanAngle * _leanLR) * -_rb.transform.forward);
        //}

    }
}
