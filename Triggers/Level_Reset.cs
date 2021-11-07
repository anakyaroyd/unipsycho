using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Reset : MonoBehaviour
{

    public Rigidbody _rb;

    [SerializeField] private float _grounded = 0;
    [SerializeField] private float _seatAngleZ;
    [SerializeField] private float _seatAngleX;

    public bool canCrash;

    public int timesCrashed;

    public void Start() {
        _grounded = 0f;
    }

    private void Update() {
        _seatAngleZ = transform.rotation.z;
        _seatAngleX = transform.rotation.x;

        if(_seatAngleX > .50f || _seatAngleX < -.50f)  {
            canCrash = true;
        }

        if (_seatAngleZ > .50f || _seatAngleZ < -.50f) {
            canCrash = true;
        }
    }

    private IEnumerator OnTriggerStay(Collider colInfo)   {   
        if (colInfo.tag == "Ground" || colInfo.tag == "AirDuct") {
            _grounded++;
        }

        if (_grounded > 16f && canCrash == true)  {
            
            _grounded = 0f;
            yield return new WaitForSeconds(0.5f);
            ResetLevel();  
        }
    }

    void ResetLevel() {
        timesCrashed = PlayerPrefs.GetInt("PlayerCrashes");
        PlayerPrefs.SetInt("PlayerCrashes", timesCrashed + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

