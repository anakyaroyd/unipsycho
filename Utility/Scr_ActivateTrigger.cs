using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ActivateTrigger : MonoBehaviour
{
    private Transform[] letters;

    private void Awake() {
        letters = gameObject.GetComponentsInChildren<Transform>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Unicycle")) {

            int count = transform.childCount; // get the child count

            for (int i = 0; i < count; i++) { 
                    transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
