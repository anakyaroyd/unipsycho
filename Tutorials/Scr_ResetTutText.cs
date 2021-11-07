using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ResetTutText : MonoBehaviour
{
    [Header ("Define Components")]
    Animation anim;

    Scr_InputController input;

    GameObject[] unis;
    Rigidbody[] uniRBs;

    [Header ("Define Variables")]
    public GameObject resetTutText;
    public GameObject pressContinueText;
    public GameObject blackBkgd;

    private bool _isPlaying;

    void Awake() {

        // get components
        anim = GetComponent<Animation>();

        input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        unis = GameObject.FindGameObjectsWithTag("Unicycle");

        // set "is playing" bool default to false 
        _isPlaying = false;

    }

    private void Update() {

        // if the animation is playing, and the player presses "continue," the tutorial end function is called
        if (_isPlaying == true){
            if (input.SelectInput != 0f) {
                StopResetTutorial();
            }
        }
    }

    // function to initialize reset tutorial
    public void ShowResetTutorial() {
        anim.enabled = true;

        // activate tutorial image panels
        resetTutText.SetActive(true);
        pressContinueText.SetActive(true);
        blackBkgd.SetActive(true);

        // set all unicycle rigidbodies to kinematic, so they won't move during tutorial
        foreach (var uni in unis) {
            if (uni.GetComponent<Rigidbody>() != null) {
                //uni.GetComponent<Rigidbody>().isKinematic = true;
                uni.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            } 
        }

        _isPlaying = true;
        // fade in tutorial text and transparent black bkgd, flash "press to continue"
        anim.Play("ResetTutText_FadeIn");
        _isPlaying = false;

    }

    // function to stop reset tutorial
    public void StopResetTutorial() {

        // play fade out animation for tutorial panels
        anim.Play("ResetTutText_FadeOut");
        _isPlaying = false;

        // Set all unicycle rigidbodies back to non-kinematic
        foreach (var uni in unis) {
            uni.GetComponent<Rigidbody>().isKinematic = false;
        }

        // deactivate tutorial panels
        resetTutText.SetActive(false);
        pressContinueText.SetActive(false);
        blackBkgd.SetActive(false);

        anim.enabled = false;
    }
}
