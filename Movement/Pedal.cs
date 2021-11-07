using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    UnicycleController _controls;

    Rigidbody _rb;

    [SerializeField] private float _pedal;

    public float wheelVel;

    public float maxSpeed;
    public float timeZeroToMax;
    public float accelRatePerSec;
    public float angularVelocity;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _controls = new UnicycleController();

        _controls.Gameplay.Pedal.performed += ctx => _pedal = ctx.ReadValue<float>();
        _controls.Gameplay.Pedal.canceled += ctx => _pedal = 0f;

        accelRatePerSec = maxSpeed / timeZeroToMax;
        angularVelocity = 0f;
    }

    private void FixedUpdate()
    {
        if (_pedal != 0)
        {
            angularVelocity += accelRatePerSec;
            angularVelocity = Mathf.Min(angularVelocity, maxSpeed);

            if (_pedal > 0)
            {
                _rb.AddTorque((_pedal * angularVelocity) * _rb.transform.right, ForceMode.Acceleration);
                maxSpeed = 1200f;
                timeZeroToMax = 100f;
            }
            else
            {
                _rb.AddTorque((_pedal * (angularVelocity*0.7f)) * _rb.transform.right, ForceMode.Acceleration);
                maxSpeed = 800f;
                timeZeroToMax = 140f;
            }
        }
        else
        {
            angularVelocity -= 50f;

        }

        if(angularVelocity < 0f)
        {
            angularVelocity = 0;
        }

        _rb.maxAngularVelocity = 50f;

        wheelVel = _rb.angularVelocity.magnitude;

    }

    private void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
