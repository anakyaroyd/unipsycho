using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_Fork_COM : MonoBehaviour {
    private Rigidbody _rb;

    public Vector3 CenterOfMass2 = new Vector3(0, 0.47f, 0);

    public bool Awake;

    void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
        CenterOfMass2 = new Vector3(0, 0.47f, 0);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, .02f);
    }
}
