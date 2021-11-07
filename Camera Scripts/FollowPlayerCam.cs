using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam : MonoBehaviour
{
    // public GameObject camTarget;
    public Transform unicycle;

    // public Vector3 offset;

    //  public Vector3 cameraTilt;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 offset = new Vector3(0f,1.5f, -2.5f);

        // transform.position = lightTarget.transform.position + offset;
        transform.LookAt(unicycle);
        // transform.Rotate(cameraTilt);
    }
}
