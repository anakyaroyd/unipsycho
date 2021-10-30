using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Wheel : MonoBehaviour
{
    [Header("Components")]

    Rigidbody _rb;

    [Header("Get Input & Input Values")]

    Scr_InputController input;

    public float PedalInput { get; set; }
    public float TiltFBInput { get; set; }

    [Header("Movement Variables")]

    [SerializeField] private float _push;
    [SerializeField] private float _pushOG = 800f;

    [SerializeField] private float _lean = 0f;
    [SerializeField] private float _pedal;

    [SerializeField] private float wheelVel;

    private void Awake()  {
        // Call Components
        _rb = GetComponent<Rigidbody>();

        input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        // Set maximum angular velocity
        _rb.maxAngularVelocity = 40f;
    }

    private void Update()  {
           // Call pedal input value from Input Controller
        PedalInput = input.PedalInput;

           // Expose PedalInput in inspector through _pedal variable
        _pedal = PedalInput;

           // Call lean forward/backwards input value from Input Controller
        TiltFBInput = input.TiltFBInput;

           // Expose speed of wheel spin in inspector via serialized field above
        wheelVel = _rb.angularVelocity.magnitude; 
    }

    private void FixedUpdate()  {
            // If player leans unicycle fork, add to acceleration (less if leaning backwards)
        if(TiltFBInput > 0f) {
            _lean = Mathf.Min((_lean + (TiltFBInput * .2f)), .5f);
        }
        else{
            _lean = TiltFBInput * .2f;
        }

            // If player presses pedal (value on axis is not equal to zero)
        if (PedalInput != 0f){
               // Add more "push" to accelerate faster
            if (_push < 1600f) { 
                _push += 40f;
            }
               // Add torque to spin wheel
            if (PedalInput > 0f) {
                // if pedalling forward 
                _rb.AddTorque((_push * (PedalInput + _lean)) * _rb.transform.right);
            }
            else {
                // if pedalling backwards
                _rb.AddTorque(((_push * .6f) * (PedalInput + _lean)) * _rb.transform.right);
            }
        }
        else {
                // Reset acceleration to baseline when player lets off pedal
            _push = _pushOG;
        }  
    }
}
