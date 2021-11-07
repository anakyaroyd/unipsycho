using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalAcc : MonoBehaviour
{
    //Rigidbody rb;

    //public float maxSpeed = 20f;
    //public float timeZeroToMax = 2.5f;
    //float accelRatePerSec;
    //float forwardVelocity;

    //private bool newInput; 

    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();

    //    accelRatePerSec = maxSpeed / timeZeroToMax;
    //    forwardVelocity = 0f;
    //}

    //public override void ReadInput (InputData data)
    //{
    //    // register and execute vehicle controls

    //    if (data.buttons[0] == true)
    //    {
    //        forwardVelocity += accelRatePerSec * Time.deltaTime;
    //        forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
    //    }

    //    newInput = true;
    //}

    //private void LateUpdate()
    //{
    //    rb.velocity = transform.forward * forwardVelocity;

    //    newInput = false;
    //}
}
