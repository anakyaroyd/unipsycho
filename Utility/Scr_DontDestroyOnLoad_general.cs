using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_DontDestroyOnLoad_general : MonoBehaviour {

    private static Scr_DontDestroyOnLoad_general _instance;

    void Awake() {

        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(_instance);
        } else {
            Destroy(gameObject);
        }
    }
}