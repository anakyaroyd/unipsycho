using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_SeatGlow_ChJump : MonoBehaviour
{
    private GameObject uni;

    public Material glowMat;

    public Shader seatShad;

    public float jumpPressure;
    public float glowInt;

    public void Awake() {
        uni = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate() {
        jumpPressure = uni.GetComponent<Scr_ChargedJump>()._jumpPressure;

        glowInt = (jumpPressure * 30f) - 13f;

        if (glowInt < -1f) {
            glowInt = -1f;
        }

        glowMat.SetFloat("_slider", glowInt);
    }
}
