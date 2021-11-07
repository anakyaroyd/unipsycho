using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Scene : MonoBehaviour
{
    Scr_InputController _input;

    int _reset;

    void Awake()
    {
        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
    }

    private void Update() {
        _reset = _input.ResetInput;

        if (_reset != 0) {
            ResetUni();
        }
    }

    void ResetUni()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
