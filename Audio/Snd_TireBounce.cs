using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snd_TireBounce : MonoBehaviour
{
    public Rigidbody uniRB;

    public Scr_GroundCheck groundCheck;

    private AudioSource source;

    public float uniVel;

    private bool _isGrounded;
    private bool canSound;

    [SerializeField] private float _airTimer;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    private void Update() {

        _isGrounded = groundCheck.isGrounded;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        uniVel = uniRB.velocity.magnitude;


        if (_isGrounded == false)
        {
            canSound = false;
            _airTimer++;
        }

        if (_airTimer >= 15f)
        {
            canSound = true;
        }


        if (canSound == true)
        {
            if (_isGrounded == true)
            {
                if (_airTimer >= 15f) {
                    source.volume = .2f;
                }

                if (_airTimer >= 35f) {
                    source.volume = .4f;
                }

                if (_airTimer >= 60f) {
                    source.volume = .08f;
                }
                source.Play();
                _airTimer = 0f;
                canSound = false;
            }
        }

        if (canSound == false)
        {
            
        }

    }
}
