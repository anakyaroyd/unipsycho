using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu_TheOffice : MonoBehaviour
{
    Scr_InputController _controls;

    public GameMaster gm;

    public Checkpoints cPList;

    public GameObject uni;

    [Header ("Menu Objects")]

    public GameObject _pauseMenu;
    public GameObject _dzMenu;
    public GameObject _controlsLayout;

    public GameObject _pauseFirstBtn;
    public GameObject _dzFirstBtn;
    public GameObject _controlsFirstBtn;
   

    private bool _isPaused;
    private bool _navigateBack;
    private bool _canNavigateBack;

    private void Awake()
    {
        _controls = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _isPaused = false;
        _navigateBack = false;
        _canNavigateBack = false;
    }

    void Update() {
        if(_controls.PauseInput != 0) {
            PauseGame();
        }

        if(_controls.BackInput != 0) {
            _navigateBack = true;
        } else {
            _navigateBack = false;
        }

        if (_isPaused == true && _navigateBack == true) {
            if (_pauseMenu == true) {
                ResumeGame();
                _navigateBack = false;
            } else if (_dzMenu == true) {
                BackToPause();
                _navigateBack = false;

            } else if (_controlsLayout == true) {
                BackToPause();
                _navigateBack = false;

            }
        }
    }

    public void PauseGame()
    {
        if (_isPaused == false)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Time.timeScale = 0f;
            _pauseMenu.SetActive(true);
            _isPaused = true;
            _canNavigateBack = true;
            EventSystem.current.SetSelectedGameObject(_pauseFirstBtn);

        }
        else
        {
            Time.timeScale = 1f;
            _pauseMenu.SetActive(false);
            _isPaused = false;
            _canNavigateBack = false;

        }
    }

    public void MainMenu()
    {
        gm.lastCheckpointPos = new Vector3(-3.625f, 0f, 2.075f);
        gm.lastCheckpointRot = new Quaternion(0, 43.03f, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        SceneManager.LoadScene("Title Screen");
       
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DZMenu()
    {
        EventSystem.current.SetSelectedGameObject(null);
        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_dzFirstBtn);

    }

    public void ControlsLayout()
    {
        EventSystem.current.SetSelectedGameObject(null);
        _pauseMenu.SetActive(false);
        _controlsLayout.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_controlsFirstBtn);

    }

    public void BackToPause()
    {
        EventSystem.current.SetSelectedGameObject(null);
        _pauseMenu.SetActive(true);
        _controlsLayout.SetActive(false);
        _dzMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(_pauseFirstBtn);

    }

    public void Back()
    {
        if (_canNavigateBack == true)
        {
            _navigateBack = true;
        }
        else
        {
            _navigateBack = false;
        }
    }

    public void MidGird()
    { 

        uni.transform.position = new Vector3(-11.775f, 23.1f, 15.225f);
        uni.transform.rotation = new Quaternion(0, 0, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CornGird()
    {
        uni.transform.position = new Vector3(7.5f, 23.1f, 46.7f);
        uni.transform.rotation = new Quaternion(0, 270, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CorysDesk()
    {
        uni.transform.position = new Vector3(2.825f, 5.075f, 26.025f);
        uni.transform.rotation = new Quaternion(0, 0, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CoffeeStation()
    {
        uni.transform.position = new Vector3(4.85f, 6.5f, -15.925f);
        uni.transform.rotation = new Quaternion(0, 270, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }
}
