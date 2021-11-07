using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_FadeInFadeOut_anim : MonoBehaviour
{
    private Animation anim;

    private void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void Start() {
        anim.Play("Crossfade_End");
        new WaitForSeconds(2f);
        anim.Play("Crossfade_Start");
    }
}
