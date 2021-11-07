using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    //public GameObject loadingScreen;
    //public Slider slider;

    //MenuController _menuControls;

    //public void Awake()
    //{
    //    _menuControls = new MenuController();

    //    _menuControls.MainMenu.Select.performed += ctx => PlayGame();
    //}

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

    //public void LoadLevel(int sceneIndex)
    //{
    //    StartCoroutine(LoadAsynchronously(sceneIndex));

    //}

    //IEnumerator LoadAsynchronously (int sceneIndex)
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

    //private void OnEnable()
    //{
    //    _menuControls.MainMenu.Enable();
    //}

    //private void OnDisable()
    //{
    //    _menuControls.MainMenu.Disable();
    //}

}
