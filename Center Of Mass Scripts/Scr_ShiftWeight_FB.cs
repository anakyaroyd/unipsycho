using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_ShiftWeight_FB : MonoBehaviour {

    private Rigidbody _rb;

    public Rigidbody uniRB;

    public Rigidbody forkRB;

    public Vector3 CenterOfMass2;

    public bool Awake;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();

        offset = new Vector3(0, 0, forkRB.rotation.x * .01f);
    }

    private void FixedUpdate() {
        CenterOfMass2 = uniRB.transform.position + offset;
        //transform.rotation = forkRB.transform.rotation;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(transform.position + (transform.rotation * CenterOfMass2), .02f);
    }
}
