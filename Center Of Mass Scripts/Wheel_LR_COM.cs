using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Wheel_LR_COM : MonoBehaviour
{
    public Vector3 CenterOfMass2;
    public bool Awake;
    private Rigidbody _rb;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    void Update() {
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
        _rb.centerOfMass = CenterOfMass2;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(transform.position + (transform.rotation * CenterOfMass2), .02f);
    }
}
