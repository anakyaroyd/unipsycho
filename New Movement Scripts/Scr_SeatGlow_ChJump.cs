using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// When the player charges the jump by holding the Crouch button,
// the seat glows brighter and brighter until released, indicating the level of charge

public class Scr_SeatGlow_ChJump : MonoBehaviour
{
        // Define components
    Scr_ChargedJump chJump;

    private GameObject uni;

    public Material glowMat;

    public Shader seatShad;

        // Define variables
    private float _jumpPressure;
    public float glowInt;

    private bool _shouldJump;

    public void Awake() {
            // Get components
        uni = GameObject.FindGameObjectWithTag("Player");

        chJump = uni.GetComponent<Scr_ChargedJump>();

    }

    private void Start() {

        glowInt = -1;
    }

    private void Update() {

        // Call shouldJump and jump pressure from ch jump script
        _shouldJump = chJump.shouldJump;
        _jumpPressure = chJump.jumpPressure;

        // In order to optomize performance, only run this code if the unicycle
        // "should jump" (from charged jump script)
        if (_shouldJump) {

            // Glow intensity increases with jump pressure
            glowInt = (_jumpPressure * 400f) - 121f;

        } else {
            glowInt = -1;
        }

        // set minimum glow
        if (glowInt < -1f) {
            glowInt = -1f;
        }

        // Set glow slider in inspector
        glowMat.SetFloat("_slider", glowInt);
    }
}
