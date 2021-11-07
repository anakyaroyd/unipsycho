using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_GroundCheck : MonoBehaviour {
    public bool isGrounded;

    // Grounded if the wheel collider collides with any collider marked "ground" or "air duct"
    public void OnTriggerStay(Collider other) {
        if (other.CompareTag("Ground")) {
            isGrounded = true;
        } else { isGrounded = false; }

    }

    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Ground")) {
            isGrounded = false;
        }
    }
}