using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.InputSystem.Interactions;
using UnityEngine;
//using HardlyBrief.Movement;


// IMovementControls is an interface that I added from my previous tutorials on Rigidybody Movement
// https://youtu.be/AwJbOJMFfAg - Rigidbody Movement Tutorial Part 1
// https://youtu.be/mzexbp54p8Q - Rigidbody Movement Tutorial Part 2
public class Movement : MonoBehaviour //, IMovementControls
{
    //// Jump Example
    //// Uses Tap and SlowTap interactions
    //public event System.Action JumpPerformed;
    //public event System.Action JumpHeldStarted;
    //public event System.Action JumpHeldPerformed;
    //public event System.Action HeldInteractionCancelled;

    //// Dash command
    //// Multitap interaction
    //public event System.Action Dash;


    ////  Covered in Rigidbody Movement Tutorials
    //// Required for the IMovementControls interface
    //public event Action Joomp;
    //public event System.Action SprintStarted;
    //public event System.Action SprintCancelled;
    //public Vector2 MoveDirection { get { return _moveDirection; } }
    //private Vector2 _moveDirection;


    //private UnicycleController _gameControls;


    //private void Awake()
    //{
    //    _gameControls = new UnicycleController();
    //    Setup();
    //}

    //private void Setup()
    //{
    //    //// Normal movement setup in previous tutorials
    //    //_gameControls.Movement.Move.performed += context => _moveDirection = context.ReadValue<Vector2>();
    //    //_gameControls.Movement.Move.canceled += context => _moveDirection = Vector2.zero;

    //    // Normal movement setup in previous tutorials
    //    //_gameControls.Movement.Joomp.performed += context =>
    //    //{
    //    //    Joomp?.Invoke();
    //    //};


    //    //// Jump Controls, Tap vs Slow Tap
    //    //_gameControls.Movement.Jump.started += context =>
    //    //{
    //    //    if (context.interaction is SlowTapInteraction)
    //    //    {
    //    //        JumpHeldStarted?.Invoke();
    //    //    }
    //    //};

    //    //_gameControls.Movement.Jump.performed += context =>
    //    //{
    //    //    if (context.interaction is SlowTapInteraction)
    //    //    {
    //    //        JumpHeldPerformed?.Invoke();
    //    //    }
    //    //    else
    //    //    {
    //    //        JumpPerformed?.Invoke();
    //    //    }
    //    //};


    //    // Interaction Controls, Tap vs Hold for time
    //    _gameControls.Movement.Jump.started += context =>
    //    {
    //        if (context.interaction is HoldInteraction)
    //        {
    //            HeldInteractStarted?.Invoke(((HoldInteraction)context.interaction).duration);
    //        }
    //    };

    //    _gameControls.Movement.Jump.performed += context =>
    //    {
    //        if (context.interaction is HoldInteraction)
    //        {
    //            HoldInteraction interaction = (HoldInteraction)context.interaction;

    //            HeldInteractPerformed?.Invoke();
    //        }
    //        else
    //        {
    //            InteractPerformed?.Invoke();
    //        }
    //    };

    //    _gameControls.Movement.CancelJump.performed += context =>
    //    {
    //        if (context.interaction is HoldInteraction)
    //        {
    //            HeldInteractionCancelled?.Invoke();
    //        }
    //    };


    //    // Dash Controls, Multi Tap
    //    _gameControls.Movement.Dash.performed += context => Dash?.Invoke();
    //    _gameControls.Movement.ControllerDash.performed += context => Dash?.Invoke();
    //}

    //private void OnEnable()
    //{
    //    _gameControls.Enable();
    //}

    //private void OnDisable()
    //{
    //    _gameControls.Disable();
    //}

}
