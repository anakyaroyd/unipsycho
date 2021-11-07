using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IsKinematic : MonoBehaviour
{

    public Rigidbody _rb;

    UnicycleController _controls;

    [SerializeField] private bool _pedal;

    //  [SerializeField] private bool _isKinematic;
    //[SerializeField] private float _pedalKin;


    void Awake()
    {
        _controls = new UnicycleController();

        _controls.Gameplay.Pedal.performed += ctx => _pedal = ctx.ReadValue<bool>();

        new WaitForSeconds(4);

        Time.timeScale = 0;
    }

    void Update()
    {
       if (_pedal == true)
        {
            Time.timeScale = 1;
        }

       // Mathf.Clamp(_pedalKin, 0, 5f);
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
