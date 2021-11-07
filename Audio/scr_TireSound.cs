using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_TireSound : MonoBehaviour
{
    public AudioSource tireSound;

    private Rigidbody rb;

    public float uniVel;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        uniVel = rb.velocity.magnitude;

        if (uniVel != 0)
        {
            tireSound.volume = uniVel;


        }
    }
}
