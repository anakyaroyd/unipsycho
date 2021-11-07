using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_Lean_LR_COM : MonoBehaviour
{
    private Rigidbody _rb;

    Scr_InputController _input;

    Scr_AirControl _ac;

    public Vector3 CenterOfMass2;

    public bool isAwake;

    private void Awake() {

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _rb = GetComponent<Rigidbody>();

        _ac = GetComponent<Scr_AirControl>();

        CenterOfMass2 = new Vector3(0, 0.47f, 0);
    }

    private void FixedUpdate() {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        isAwake = !_rb.IsSleeping();

        if (_ac.airControls) {
            CenterOfMass2 = new Vector3(0, 0.17f, 0);
        } else {
            CenterOfMass2 = new Vector3(_input.LeanLRInput * .5f, 0.47f - Mathf.Abs(_input.LeanLRInput * .2f), 0);
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, .02f);
    }
}
