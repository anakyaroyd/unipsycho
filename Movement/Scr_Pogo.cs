using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Scr_Pogo : MonoBehaviour
{
    private Rigidbody _rb;

    public Rigidbody _forkRB;

    public GameObject gc;

    UnicycleController _controls;

    [SerializeField] private float pogoForce;
    [SerializeField] private float _pogo;

    public bool _grounded;

    public bool _canPogo;


    private void Awake()
    {
        _controls = new UnicycleController();

        _controls.Gameplay.Pogo.performed += ctx => _pogo = ctx.ReadValue<float>();

        
    }

    private void FixedUpdate()
    {

        Debug.Log("Pogo = " + _pogo);
        //_grounded = gc.GetComponent<Ground_Check>().isGrounded;

        //if (_grounded == true && _canPogo == true)
        //{
        //    _rb.AddForce(_forkRB.transform.up * pogoForce, ForceMode.Impulse);
        //}
    }

    //void Pogo()
    //{
    //    _canPogo = true;
    //}
}
