using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header ("Get Components")]
    private GameObject uni;

    public Checkpoints currentCP;

    private static GameMaster instance;

    //private Scr_GM_CP_List cpLocations;

    [Header ("Player Position/Rotation")]
    public Vector3 lastCheckpointPos;
    public Quaternion lastCheckpointRot;

    private void Awake()  {
        // Destory if duplicate
        if (instance == null)  {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else {
            Destroy(gameObject);
        }

        //// Get list of CP locations
        //cpLocations = GetComponent<Scr_GM_CP_List>();

        // Get unicycle
        uni = GameObject.FindGameObjectWithTag("Player");
    }

    public void Start() {
        // If checkpoint is set to "Current Position," leave unicycle at current pos/rot
        if (currentCP == Checkpoints.CP_CurrentPosition) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        #region // Tutorial Checkpoints
        if (currentCP == Checkpoints.CP_BowlingAlley) {
            //cpLocations.CP_BowlingAlley();

            lastCheckpointPos = new Vector3(1.834f, -0.283f, 11.221f);
            lastCheckpointRot = new Quaternion(0, 0, 0, 1);
        }

        #endregion

        #region // Office Checkpoints

        if (currentCP == Checkpoints.SP_TO) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        if (currentCP == Checkpoints.MidGird) {
            lastCheckpointPos = new Vector3(-1.45f, -4.725f, 25.875f);
            lastCheckpointRot = new Quaternion(0, 180, 0, 0);
        }

        if (currentCP == Checkpoints.CornGird) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        if (currentCP == Checkpoints.CorysDesk) {
            lastCheckpointPos = new Vector3(-1.375f, -6.075f, 11.6f);
            lastCheckpointRot = new Quaternion(0, 90, 0, 0);
        }

        if (currentCP == Checkpoints.CoffeeStation) {
            lastCheckpointPos = new Vector3(4.85f, 6.5f, -15.925f);
            lastCheckpointRot = new Quaternion(0, 270, 0, 0);

            //lastCheckpointPos = new Vector3(15.9f, -3.9f, 12.75f);
            //lastCheckpointRot = new Quaternion(0, 0, 0, 0);
        }

        if (currentCP == Checkpoints.CopyArea) {
            lastCheckpointPos = new Vector3(-20.08f, 5.69f, 3.35f);
            lastCheckpointRot = new Quaternion(0, 270, 0, 0);
        }

        if (currentCP == Checkpoints.Partition) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        if (currentCP == Checkpoints.TopOfTheLadder) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        if (currentCP == Checkpoints.TopOfTheLighter) {
            lastCheckpointPos = uni.transform.position;
            lastCheckpointRot = uni.transform.rotation;
        }

        #endregion
    }
}
