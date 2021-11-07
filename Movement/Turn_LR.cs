using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_LR : MonoBehaviour
{

    [Header("---Components---")]

    public Rigidbody _rigidbody;
    public Rigidbody _wheelRB;

    Scr_InputController _controls;

    #region // Floats --------------

    [Header("---Control Inputs---")]

    [SerializeField] private float turn;
    [SerializeField] private float _turnSpeed = 1500f;
    [SerializeField] private float _thrustSpeed;

    [SerializeField] private float _turnTimer;
    [SerializeField] private float _uniVel;

    public float inertia, torque;
    public float timeToStop;

    public float AngularAcceleration = 6.28f;

    public bool slowDown;

    #endregion // ----------------

    private void Awake() {
        //  _rigidbody = GetComponent<Rigidbody>();

        _controls = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

    }

    void Start() {
        //inertia = _rigidbody.inertiaTensor.z;
        //torque = inertia * AngularAcceleration;
        //_uniVel = _rigidbody.angularVelocity.magnitude;
    }

    private void FixedUpdate() {
        //_uniVel = _rigidbody.angularVelocity.magnitude;

        turn = _controls.TurnInput;

        _rigidbody.AddTorque((turn * _turnSpeed) * _rigidbody.transform.up, ForceMode.Force);

        if (turn < .02 && turn > -.02) {
            _wheelRB.angularVelocity = new Vector3(_wheelRB.angularVelocity.x * .1f, _wheelRB.angularVelocity.y * .1f, _wheelRB.angularVelocity.z * .1f);

        }

    }
}

//Rigidbody rb;
//float inertia, torque;
//float timeToStop;

//public float AngularAcceleration = 6.28f;

//void Awake()
//{
//    rb = GetComponent<Rigidbody>();
//}

//void Start()
//{
//    inertia = rb.inertiaTensor.z;
//    torque = inertia * AngularAcceleration;
//}

//void Update()
//{
//    if (Input.GetKey(KeyCode.LeftArrow))
//    {
//        rb.AddTorque(Vector3.forward * torque);
//    }
//    else if (Input.GetKey(KeyCode.A))
//    {
//        timeToStop = rb.angularVelocity.z / AngularAcceleration;
//    }

//    if (timeToStop > 0f)
//    {
//        rb.AddTorque(Vector3.back * torque);
//        timeToStop -= Time.deltaTime;
//    }
//}
//}
