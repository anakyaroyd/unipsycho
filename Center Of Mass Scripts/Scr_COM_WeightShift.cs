using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_COM_WeightShift : MonoBehaviour
{
    private Rigidbody _rb;

    Scr_InputController _input;

    public Vector3 CenterOfMass2 = new Vector3(0, 0.07f, 0);

    public bool isAwake;

    [SerializeField] private Vector2 stickPos;

    private void Awake() {

        _input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();

        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _rb.centerOfMass = CenterOfMass2;
        _rb.WakeUp();
        isAwake = !_rb.IsSleeping();
        CenterOfMass2 = new Vector3(_input.ShiftWeightInput.x * .5f, 0.07f, _input.ShiftWeightInput.y * .5f);

        stickPos = new Vector2(_input.ShiftWeightInput.x, _input.ShiftWeightInput.y);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, .1f);
    }
}
