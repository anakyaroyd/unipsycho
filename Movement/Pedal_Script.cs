using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pedal_Script : MonoBehaviour
{
    public Rigidbody _rb;

    UnicycleController _controls;

    [SerializeField] private float _pedalPower = 3000f;
    [SerializeField] private float _pedal;


    void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        _controls = new UnicycleController();

        _controls.Gameplay.Pedal.performed += ctx => _pedal = ctx.ReadValue<float>();
    }

    void FixedUpdate()
    {
        _rb.AddTorque((_pedal * _pedalPower) * _rb.transform.right, ForceMode.Acceleration);

        _rb.maxAngularVelocity = 20;
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
