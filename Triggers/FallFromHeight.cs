using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFromHeight : MonoBehaviour
{
    [SerializeField] HingeJoint _forkHJ;
    [SerializeField] HingeJoint _wheelHJ;

    [SerializeField] GameObject _gCheck;

    [SerializeField] private bool _isGrounded;
    [SerializeField] private float _airTimer = 0f;

    private void Awake()
    {
        _forkHJ = GetComponent<HingeJoint>();
        _wheelHJ = GetComponent<HingeJoint>();

    }

    // Start is called before the first frame update
    void Start()
    {
        Mathf.Clamp(_airTimer, 0, 100);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _isGrounded = _gCheck.GetComponent<Ground_Check>().isGrounded;

        if (_isGrounded == false)
        {
            _airTimer++;

        }
        else
        {
            _airTimer = 0;
        }

        if (_airTimer >= 80f)
        {
            _forkHJ.breakForce = 3;
            _wheelHJ.breakForce = 3;
            
        }
        else
        {
            _forkHJ.breakForce = Mathf.Infinity;
            _wheelHJ.breakForce = Mathf.Infinity;
        }
    }
}
