using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_LevelReset_ProtoPark : MonoBehaviour
{

    public Rigidbody _rb;


    [SerializeField] private float _grounded = 0;
    [SerializeField] private float _seatAngleZ;
    [SerializeField] private float _seatAngleX;

    public bool canCrash;

    private void Update()
    {
        _seatAngleZ = transform.rotation.z;
        _seatAngleX = transform.rotation.x;


        if(_seatAngleX > .50f || _seatAngleX < -.50f)
        {
            canCrash = true;
        }

        if (_seatAngleZ > .50f || _seatAngleZ < -.50f)
        {
            canCrash = true;
        }
    }

    private IEnumerator OnTriggerStay(Collider colInfo)
    {
        if (colInfo.tag == "Ground" || colInfo.tag == "AirDuct")
        {
            _grounded++;
        } else { _grounded = 0f; }

        if (_grounded > 50f && canCrash == true)
        {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

