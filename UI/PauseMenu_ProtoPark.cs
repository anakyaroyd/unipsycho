using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu_ProtoPark : MonoBehaviour
{
    MenuController _controls;

    public Checkpoints cPList;

    [Header ("Declare GameObjects")]
    public GameObject _pauseMenu;
    public GameObject _dzMenu;
    public GameObject _controlsLayout;

    private GameObject uni;

    [Header ("Declare Variables")]
    [SerializeField] private bool _isPaused;

    private void Awake()
    {
        _controls = new MenuController();

        _controls.PauseMenu.Pause.performed += ctx => PauseGame();

        _isPaused = false;

        uni = GameObject.FindGameObjectWithTag("Unicycle");
    }

    public void PauseGame()
    {
        if (_isPaused == false)
        {
            Time.timeScale = 0f;
            _pauseMenu.SetActive(true);
            _isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            _pauseMenu.SetActive(false);
            _isPaused = false;
        }
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
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

    public void DZMenu()
    {
        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(true);
    }

    public void ControlsLayout()
    {
        _pauseMenu.SetActive(false);
        _controlsLayout.SetActive(true);
    }

    public void MidGird()
    {
        uni.transform.position = new Vector3(-1.45f, -4.725f, 25.875f);
        uni.transform.rotation = new Quaternion(0, 180, 0, 0);

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);

        cPList = Checkpoints.CPoint_00;
    }

    public void CornGird()
    {
        uni.transform.position = new Vector3(-1.375f, -6.075f, 11.6f);
        uni.transform.rotation = new Quaternion(0, 90, 0, 0);

        cPList = Checkpoints.CPoint_01;

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CorysDesk()
    {
        uni.transform.position = new Vector3(9.775f, -1.325f, 33.5f);
        uni.transform.rotation = new Quaternion(0, 270, 0, 0);

        cPList = Checkpoints.CPoint_02;

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CoffeeStation()
    {
        uni.transform.position = new Vector3(15.9f, -3.9f, 12.75f);
        uni.transform.rotation = new Quaternion(0, 0, 0, 0);


        cPList = Checkpoints.CPoint_03;

        Time.timeScale = 1f;
        _isPaused = false;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    private void OnEnable()
    {
        _controls.PauseMenu.Enable();
    }

    private void OnDisable()
    {
        _controls.PauseMenu.Disable();
    }
}
