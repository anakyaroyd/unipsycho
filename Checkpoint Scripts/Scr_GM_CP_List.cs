using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_GM_CP_List : MonoBehaviour
{
    MenuController _controls;

    public Checkpoints cPList;

    [Header("Declare GameObjects")]
    public GameObject _pauseMenu;
    public GameObject _dzMenu;
    public GameObject _controlsLayout;

    private GameObject uni;

    private void Awake() {

        uni = GameObject.FindGameObjectWithTag("Player");
    }

    #region // ProtoPark Checkpoints

    public void CP_BowlingAlley() {

        uni.transform.position = new Vector3(1.834f, -0.283f, 11.221f);
        uni.transform.rotation = new Quaternion(0, 0, 0, 1);

        Time.timeScale = 1f;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);

        cPList = Checkpoints.CP_BowlingAlley;
    }

    #endregion

    #region // The Office Checkpoints
    public void MidGird() {
        uni.transform.position = new Vector3(-1.45f, -4.725f, 25.875f);
        uni.transform.rotation = new Quaternion(0, 180, 0, 0);

        Time.timeScale = 1f;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);

        cPList = Checkpoints.CPoint_00;
    }

    public void CornGird() {
        uni.transform.position = new Vector3(-1.375f, -6.075f, 11.6f);
        uni.transform.rotation = new Quaternion(0, 90, 0, 0);

        cPList = Checkpoints.CPoint_01;

        Time.timeScale = 1f;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CorysDesk() {
        uni.transform.position = new Vector3(9.775f, -1.325f, 33.5f);
        uni.transform.rotation = new Quaternion(0, 270, 0, 0);

        cPList = Checkpoints.CPoint_02;

        Time.timeScale = 1f;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }

    public void CoffeeStation() {
        uni.transform.position = new Vector3(15.9f, -3.9f, 12.75f);
        uni.transform.rotation = new Quaternion(0, 0, 0, 0);


        cPList = Checkpoints.CPoint_03;

        Time.timeScale = 1f;

        _pauseMenu.SetActive(false);
        _dzMenu.SetActive(false);
        _controlsLayout.SetActive(false);
    }
    #endregion
}
