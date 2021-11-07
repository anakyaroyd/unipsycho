using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayerStats : MonoBehaviour
{
    [Header("Player Crashes")]

    public int _timesCrashed;
    public int _timesCrashedOld;

    public int PlayerCrashes { get; set; }

    void Update() {
        _timesCrashedOld = PlayerPrefs.GetInt("PlayerCrashes");

        if (_timesCrashed != _timesCrashedOld) {
            //PlayerPrefs.DeleteKey("PlayerCrashes");
            PlayerPrefs.Save();
            Debug.Log("Player crashes = " + PlayerPrefs.GetInt("PlayerCrashes"));
            _timesCrashed = PlayerPrefs.GetInt("PlayerCrashes");
        }
    }
}

//get => _timesCrashed;
//set {
//    _timesCrashed = value;

//    if (_timesCrashed != _timesCrashedOld) {
//        PlayerPrefs.Save();
//        Debug.Log("Player crashes = " + PlayerPrefs.GetInt("PlayerCrashes"));
//        _timesCrashed = PlayerPrefs.GetInt("PlayerCrashes");
//    }
//}