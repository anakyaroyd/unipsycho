using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pedal_COM : MonoBehaviour
{

    public Vector3 CenterOfMass2;
    public bool Awake;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.white;
    //    Gizmos.DrawSphere(transform.position + (transform.rotation * CenterOfMass2), .01f);
    //}
}
