using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Scene_TitleScreen : MonoBehaviour
{
    UnicycleController _controls;

    public Ground_Check _gcScript;

    // Start is called before the first frame update
    void Awake()
    {
        //_groundCheck = GetComponent<GameObject>();
        //_gcScript = GetComponent<GroundCheckScript>();

        _controls = new UnicycleController();

        _controls.Gameplay.Reset.performed += ctx => ResetUni();

    }

    void ResetUni()
    {
       // transform.position = _gcScript._spawnPoint;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        // _player.transform.rotation = spawnRot;
    }

    void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
