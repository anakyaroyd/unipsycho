using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ViewRaycast : MonoBehaviour
{

    public Transform Target, Player;

    private Transform Obstruction;
    float zoomSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Obstruction = Target;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ViewObstructed();
    }

    void ViewObstructed()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Target.position - transform.position, out hit, 4.5f))
        {
            if(hit.collider.gameObject.tag != "Unicycle")
            {
                Obstruction = hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                if(Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >= 1.5f)
                {
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
                }
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if(Vector3.Distance(transform.position, Target.position) < 4.5f)
                {
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                }
            }
        }
    }
}
