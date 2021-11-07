using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snd_TireRollVolume : MonoBehaviour
{
    [Header ("Get Components")]
    public Rigidbody uniRB;

    public Scr_GroundCheck groundCheck;

    private AudioSource source;

    [Header ("Establish Variables")]
    [SerializeField] private bool _isGrounded;
    [SerializeField] private bool canSound;

    public float uniVel;

    void Start() {
            // Call audio source
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        // Check if grounded
        _isGrounded = groundCheck.isGrounded;
    }

    // Update is called once per frame
    void FixedUpdate() {

            // Track velocity
        uniVel = uniRB.velocity.magnitude;

            // Conditions to sound off: if sound fires and at which volume
        if (uniVel < .2f) {
            canSound = false;
        }

        if(_isGrounded == false) {
            canSound = false;
        }

        if (uniVel > .2f && _isGrounded == true)  {
            canSound = true;
        }
           
        if (canSound == true) {
            source.volume = uniVel * .4f;
        }

        if (canSound == false) {
            source.volume = 0f;
        } 
    }
}
