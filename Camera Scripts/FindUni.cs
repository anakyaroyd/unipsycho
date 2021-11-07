using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FindUni : MonoBehaviour
{
    public CinemachineVirtualCamera cvCamNear;
    public CinemachineVirtualCamera cvCamReverse;

    CinemachineComposer composerNear;
    CinemachineComposer composerReverse;

    public GameObject wheel;

    private Transform player;

    [SerializeField] private float _pedalInput;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        _pedalInput = wheel.GetComponent<Scr_Wheel>().PedalInput;

        composerNear = cvCamNear.GetCinemachineComponent<CinemachineComposer>();
        composerReverse = cvCamReverse.GetCinemachineComponent<CinemachineComposer>();
    
    }

    private void LateUpdate()
    {
        if (_pedalInput < 0f) {
            composerReverse.enabled = true;
            composerNear.enabled = false;
        } else {
            composerNear.enabled = true;
            composerReverse.enabled = false;
        }
    }
}
