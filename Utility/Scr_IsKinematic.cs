using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_IsKinematic : MonoBehaviour
{
    private Rigidbody[] rbs;

    private void Awake() {
        rbs = gameObject.GetComponentsInChildren<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Unicycle")) {
            foreach (var rb in rbs) {
                rb.isKinematic = false;
            }
        }
    }
}
