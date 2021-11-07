using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Scr_FindUni : MonoBehaviour
{
    public CinemachineVirtualCamera cvCam;

    public GameObject wheel;

    [SerializeField] private float _pedalInput;

    private void Awake()
    {
        cvCam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
        cvCam.LookAt = GameObject.FindGameObjectWithTag("Player").transform;


    }

    private void FixedUpdate()
    {
        cvCam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
        cvCam.LookAt = GameObject.FindGameObjectWithTag("Player").transform;

        _pedalInput = wheel.GetComponent<Scr_Wheel>().PedalInput;

        if (_pedalInput < 0f)
        {
            cvCam.GetCinemachineComponent<CinemachineComposer>().enabled = true;
        }
        else
        {
            cvCam.GetCinemachineComponent<CinemachineComposer>().enabled = true;
        }
    }
}
