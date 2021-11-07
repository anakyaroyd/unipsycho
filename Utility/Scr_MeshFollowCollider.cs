using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MeshFollowCollider : MonoBehaviour
{
    [Header ("Define Target Collider and Offset")]
    public GameObject c_collider;

    public Vector3 offset;

    private void Update() 
    {
            // Follow position and rotation of target collider
        transform.position = c_collider.transform.position + offset;
        transform.rotation = c_collider.transform.rotation;
    }
}
