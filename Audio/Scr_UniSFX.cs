using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Scr_UniSFX : MonoBehaviour
{
    public Sound s;

    public AudioSource tireRoll;

    public Rigidbody uniRB;

    public UnicycleController controls;

    public GameObject groundCheck;

    public bool isGrounded;
    public bool pedal;
    public bool canSound;

    public float uniVel;

    private void Awake()
    {
        controls = new UnicycleController();

        controls.Gameplay.Pedal.performed += ctx => pedal = ctx.ReadValue<bool>();

        FindObjectOfType<AudioManager>().Play("TireRolling");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = groundCheck.GetComponent<Ground_Check>().isGrounded;

        uniVel = uniRB.velocity.magnitude;


        if (uniVel < .2f)
        {
            canSound = false;
        }

        if (isGrounded == false)
        {
            canSound = false;
        }

        if (uniVel > .2f && isGrounded == true)
        {
            canSound = true;
        }


        if (canSound == true)
        {
            tireRoll.volume = uniVel * .8f;
        }
    }
}
