using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ActivateResetTutorialTXT : MonoBehaviour
{
    public GameObject resetTutorialText;

    public float crashes;

    private void Update() {
        crashes = PlayerPrefs.GetInt("PlayerCrashes");

        if (crashes == 1) {
            resetTutorialText.GetComponent<Scr_ResetTutText>().ShowResetTutorial();
        } else {
            return;
        }
    }
}
