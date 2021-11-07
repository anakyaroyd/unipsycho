using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{

    UnicycleController _controls;

    public float fallMultiplier = 2.5f;
    public float lowJumpMulitiplier = 2f;

    Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        _controls = new UnicycleController();

        _controls.Gameplay.Launch.performed += ctx => Launch();
        //_controls.Gameplay.Crouch.performed += ctx => Crouch();
    }


    private void Launch()
    {
        if(_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
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
