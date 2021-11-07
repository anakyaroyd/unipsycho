using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChange : MonoBehaviour
{
    UnicycleController _controls;

    [SerializeField] private GameObject _cam01;
    [SerializeField] private GameObject _cam02;

    private bool _switch = true;

    void Awake()
    {
        _controls = new UnicycleController();

        _controls.Gameplay.Reset.performed += ctx => CamChange();
    }
    void CamChange()
    {
        if (_switch == true)
        { 
            _cam01.SetActive(false);
            _cam02.SetActive(true);
            _switch = false;
        }
        else
        {
            _cam01.SetActive(true);
            _cam02.SetActive(false);
        }
    }
}