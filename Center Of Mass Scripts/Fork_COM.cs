using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Fork_COM : MonoBehaviour
{
    private Rigidbody _rb;

    public Vector3 CenterOfMass2 = new Vector3(0, 0.47f, 0);

    public GameObject _forkMesh;

    public bool Awake;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        Awake = !_rb.IsSleeping();
        CenterOfMass2 = new Vector3(0, 0.47f, 0);
        _rb.transform.rotation = _forkMesh.transform.rotation;

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, .02f);
    }
}
