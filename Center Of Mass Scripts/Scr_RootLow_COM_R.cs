using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_RootLow_COM_R : MonoBehaviour {
    private Rigidbody _rb;

    public Vector3 CenterOfMass2;

    Scr_InputController _input;

    public bool Awake;

    void Start() {
        _rb = GetComponent<Rigidbody>();

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
    }

    void Update() {
        CenterOfMass2 = new Vector3(0.03f + Mathf.Abs(_input.TiltFBInput * .1f), 0.025f, 0f + Mathf.Abs(_input.TiltFBInput * .21f));

        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
    }

    //private void OnDrawGizmos() {
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawSphere(transform.position + (transform.rotation * CenterOfMass2), .02f);
    //}
}
