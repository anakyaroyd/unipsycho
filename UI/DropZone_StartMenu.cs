using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropZone_StartMenu : MonoBehaviour
{
    UIController _controls;

    private GameMaster gm;

    private GameObject uni;

    public GameObject _dzStartMenu;

    public Checkpoints cPList;

    //public GameObject mainCam;
    //public GameObject startCam;

    //private bool _isPaused;



    // Start is called before the first frame update
    void Awake()
    {
        _controls = new UIController();

        uni = GameObject.FindGameObjectWithTag("Unicycle");

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    private void Start()
    {
        Time.timeScale = 0f;

        _dzStartMenu.SetActive(true);
    }

    public void CorysDesk()
    {
        gm.lastCheckpointPos = new Vector3(2.825f, 5.075f, 26.025f);
        gm.lastCheckpointRot = new Quaternion(0, 0, 0, 0);

        cPList = Checkpoints.CorysDesk;

        Time.timeScale = 1f;

        _dzStartMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
    }

    public void CopyArea()
    {
        
        gm.lastCheckpointPos = new Vector3(-20.08f, 5.69f, 3.35f);
        gm.lastCheckpointRot = new Quaternion(0, 270, 0, 0);

        gm.currentCP = Checkpoints.CopyArea;

        Time.timeScale = 1f;
  
        _dzStartMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }

    public void CoffeeStation()
    {
        gm.lastCheckpointPos = new Vector3(4.85f, 6.5f, -15.925f);
        gm.lastCheckpointRot = new Quaternion(0, 270, 0, 0);

        gm.currentCP = Checkpoints.CoffeeStation;

        Time.timeScale = 1f;

        _dzStartMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
    }

    private void OnEnable()
    {
        _controls.UI.Enable();
    }

    private void OnDisable()
    {
        _controls.UI.Disable();
    }
}
