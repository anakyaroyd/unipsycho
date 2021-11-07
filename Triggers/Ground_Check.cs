using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Check : MonoBehaviour
{
    public bool isGrounded;

    public Vector3 _spawnPoint;

    // Grounded if the wheel collider collides with any collider marked "ground" or "air duct"
    public bool OnTriggerEnter(Collider colInfo) {
        if (colInfo.CompareTag("Ground")) {
            return isGrounded = true;
        }
        else if (colInfo.CompareTag("AirDuct")) {
            return isGrounded = true;
        }
        else {
            return isGrounded = false;
        }
    }

    // Not grounded if collider no longer touching/indside of trigger
    public bool OnTriggerExit(Collider colInfo) { 
        if (colInfo.CompareTag("Ground")) { 
            return isGrounded = false;
        }
        else if (colInfo.CompareTag("AirDuct")) {
            return isGrounded = false;
        }
        else {
            return isGrounded = true;
        }
    }

}