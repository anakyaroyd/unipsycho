using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    MenuController _menuControls;

    public GameObject uni;

    private GameObject cPList;

    //public GameObject loadingScreen;
    //public Slider slider;


    private void Awake()
    {
        _menuControls = new MenuController();

       // cPList = CheckpointProfile.cPList;
    }

    public void PlayGame()
    {

        //StartCoroutine(LoadAsynchronously(sceneIndex));

        //uni.transform.position = new Vector3(-24.7169991f, 9.64799976f, 17.5550003f);
        //uni.transform.rotation = new Quaternion(0, 180, 0, 0);

        // cPList = SP_TO;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //IEnumerator LoadAsynchronously(int sceneIndex)
    //{
    //    AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

    //    loadingScreen.SetActive(true);

    //    while (operation.isDone == false)
    //    {
    //        float progress = Mathf.Clamp01(operation.progress / .9f);

    //        slider.value = progress;

    //        yield return null;
    //    }
    //}

    //public void QuitGame()
    //{
    //    Application.Quit();
    //}

    private void OnEnable()
    {
        _menuControls.MainMenu.Enable();
    }

    private void OnDisable()
    {
        _menuControls.MainMenu.Disable();
    }
}

