using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ColliderBreakForceZero : MonoBehaviour
{
    FixedJoint[] Joints { get; set; }

    private void Awake() {
        Joints = GetComponentsInChildren<FixedJoint>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Unicycle")) {
            foreach (var joint in Joints) {
                if (joint != null) {
                    joint.breakTorque = 0f;
                    joint.breakForce = 0f;

                } else {
                    return;
                }
            }
        }
    }
}
