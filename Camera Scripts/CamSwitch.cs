using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch : MonoBehaviour
{
    /*
    UnicycleController _controls;

    //[SerializeField] public Animator _animator;

    [SerializeField] CinemachineBrain _cineBrain;
    [SerializeField] CinemachineStateDrivenCamera _cineSDC;

    [SerializeField] private bool _isPaused = false;
    [SerializeField] private bool inDuct;

    [SerializeField] private CinemachineVirtualCamera _normalCam;
    [SerializeField] private CinemachineVirtualCamera _closeCam;
    [SerializeField] private CinemachineVirtualCamera _pauseCam;
    //     [SerializeField] private CinemachineVirtualCamera _pauseFLCam;

    //[SerializeField] private bool _normalEnable = true;
    //[SerializeField] private bool _closeEnable = false;
    //[SerializeField] private bool _pauseEnabble = false;
    //     [SerializeField] private bool _pauseEnable = false;

    [SerializeField] public int normalPri = 5;
    [SerializeField] public int closePri = 4;
    [SerializeField] public int pausePri = 3;
    //      [SerializeField] public float pauseFLPri = 5;




    private void Awake()
    {
       // _animator = GetComponent<Animator>();

        _controls = new UnicycleController();

        _controls.UI.Pause.performed += ctx => SwitchPriority(); //  SwitchState();

        #region // Get Cinemachine Components

        //_normalCam = GetComponent<CinemachineVirtualCamera>();
        //_closeCam = GetComponent<CinemachineVirtualCamera>();
        //_pauseCam = GetComponent<CinemachineVirtualCamera>();
        // _pauseFLCam = GetComponent<CinemachineVirtualCamera>()

        //_cineSDC = GetComponent<CinemachineStateDrivenCamera>();

        normalPri = _normalCam.Priority;
        closePri = _closeCam.Priority;
        pausePri = _pauseCam.Priority;
        //   pauseFLPri = _pauseFLCam.m_Priority;

        #endregion
    }

    #region // Pause Camera (Switch Priority)

    void SwitchPriority()
    {
        if (normalPri == 5)
        {
            if (pausePri == 3)
            {
                pausePri = 6;
                _isPaused = true;
            }

            if (pausePri == 6)
            {
                pausePri = 3;
                _isPaused = false;
            }
        }
        else
        {

        }

        if (closePri == 5)
        {
            if (pausePri == 3)
            {
                pausePri = 6;
                _isPaused = true;
            }
            if (pausePri == 6)
            {
                pausePri = 3;
                _isPaused = false;
            }
        }
        else
        {

        }

        if (inDuct)
        {
            if (pausePri == 6)
            {
                pausePri = 3;
                closePri = 5;
                _isPaused = false;
            }

            if (pausePri == 0)
            {
                pausePri = 6;
                closePri = 5;
                _isPaused = true;
            }

        }


        if (inDuct == false)
        {
            if (pausePri == 6)
            {
                pausePri = 3;
                closePri = 4;
                normalPri = 5;
                _isPaused = false;
            }

            if (pausePri == 3)
            {
                pausePri = 6;
                closePri = 4;
                normalPri = 5;
                _isPaused = false;
            }
        }

    }
           
    #endregion

    #region // Close Follow Camera

    bool OnTriggerEnter(Collider colInfo)
    {

        if (colInfo.CompareTag("AirDuct"))
        {
            closePri = 5;
            normalPri = 4;
            return inDuct = true;
        }
        else
        {
            normalPri = 5;
            closePri = 4;
            return inDuct = false;
        }
    }

        bool OnTriggerExit(Collider colInfo)
    {
        if (colInfo.CompareTag("AirDuct"))
        {
            normalPri = 5;
            closePri = 4;
            return inDuct = false;
        }
        else
        {
            normalPri = 4;
            closePri = 5;
            return inDuct = true;
        }
    }
    #endregion

    #region // Switch Pause Camera via Input
    /*
    private void SwitchCam()
    {

        if (_normalCam)
        {
            _animator.Play("PauseCam");
            _pauseCam = true;
            _normalCam = false;
            _closeCam = false;
        }
        else
        {
            _animator.Play("NormalFollowCam");
        }
        _normalCam = !_normalCam;

    }

    #endregion

    #region // Pause Camera (Switch State)
    /*
    void SwitchState()
    {
        if (_normalCam == isActiveAndEnabled)
        {
            _animator.Play("PauseCamOH");
            _normalCam = 
            _pauseCam = isActiveAndEnabled;
                
            _closeCam = false;
            _isPaused = true;
        }
        else
        {
            _animator.Play("NormalFollowCam");
        }
        _normalCam = !_normalCam;

        if (_closeCam)
        {
            _animator.Play("InDuctPauseOH");
            _pauseCam = isActiveAndEnabled;
            _normalCam = !isActiveAndEnabled;
            _closeCam = !isActiveAndEnabled;
        }
        else
        {

        }
    } 

    #endregion}

    #region // Enable Input System

    private void OnEnable()
    {
        _controls.UI.Enable();
    }

    private void OnDisable()
    {
        _controls.UI.Disable();
    }

    #endregion
    */
}