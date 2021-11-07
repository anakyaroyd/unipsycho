using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_Wheel_Balance_L : MonoBehaviour {

    private Rigidbody _rb;

    public Vector3 CenterOfMass2;

    Scr_InputController _input;

    public bool Awake;

    void Start() {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
    }

    void Update() {
        CenterOfMass2 = new Vector3(-0.15f - Mathf.Abs(_input.TiltFBInput * .2f), 0.07f, _input.TiltFBInput * .38f);

        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
    }

    //private void OnDrawGizmos() {
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawSphere(transform.position + (transform.rotation * CenterOfMass2), .02f);
    //}
}
