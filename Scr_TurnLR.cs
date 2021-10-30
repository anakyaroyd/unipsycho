using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_TurnLR : MonoBehaviour
{
    Rigidbody _rb;

    Scr_InputController _input;

    [SerializeField] private float _turnInput;
    [SerializeField] private float _turnTorque = 125f;

    private void Awake() {
        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        _turnInput = _input.TurnInput;
    }

    private void FixedUpdate() {
        _rb.AddTorque(_turnInput * _turnTorque * _rb.transform.up);
    }
}
