using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VelocityInfo : MonoBehaviour
{
    public float uniSpeed;
    public float angularSpeed;
    protected Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        uniSpeed = _rb.velocity.magnitude;
        angularSpeed = _rb.angularVelocity.magnitude;
    }
}
