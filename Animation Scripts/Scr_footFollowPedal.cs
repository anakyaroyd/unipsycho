using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_footFollowPedal : MonoBehaviour
{
    public Rigidbody pedalRB;
    public Rigidbody footRB;

    [SerializeField] private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = pedalRB.transform.position + _offset;
        transform.rotation = pedalRB.transform.rotation;
    }
}
