using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReset : MonoBehaviour
{
    [SerializeField] private float _grounded = 0;
  
    //void Awake()
    //{
      
    //}

    
    private IEnumerator OnTriggerStay(Collider colInfo)
    {
    
       
        if (colInfo.tag == "Ground")
        {

            _grounded++;

        }

        if (_grounded > 2f)
        {

            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
       
    }
}

