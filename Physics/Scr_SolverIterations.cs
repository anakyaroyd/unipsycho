using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Scr_SolverIterations : MonoBehaviour
{

    [SerializeField]

    ushort solverIterations = 60;
 
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.solverIterations = (int)solverIterations;
    }

}
