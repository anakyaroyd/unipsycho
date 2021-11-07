using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_FixedJointCollapse : MonoBehaviour
{
    private FixedJoint[] joints;

    private void Awake() {
        joints = gameObject.GetComponentsInChildren<FixedJoint>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Unicycle")) {
            foreach (var joint in joints) {
                if (joint != null) {
                    joint.breakForce = 0f;
                    joint.breakTorque = 0f;
                }
            }
        }
    }
}
