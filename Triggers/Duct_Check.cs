using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duct_Check : MonoBehaviour
{
    public bool inDuct;

    // If collider marked duct enters trigger, "InDuct" is true
    public bool OnTriggerEnter(Collider colInfo)  {
        if (colInfo.CompareTag("AirDuct"))  {
            return (inDuct);
        }
        else  {
            return (inDuct = false);
        }
    }

    // If collider marked duct exits trigger, "InDuct" is false
    public bool OnTriggerExit(Collider colInfo) {
        if (colInfo.CompareTag("AirDuct")) {
            return (inDuct = false);
        }
        else {
            return inDuct;
        }
    }
}
