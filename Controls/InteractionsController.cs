using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

public class InteractionsController : MonoBehaviour
{
    //[SerializeField]
    //private UnicycleController _controls;

    //public Image interactImage;
    //public Image ChargeMeterImage;


    //// Testing
    //private bool _isCharging;
    //private float _chargeTime;
    //private System.Diagnostics.Stopwatch _chargeStopWatch;
    //private Coroutine _heldInteractTimerRoutine;
    //private bool _isInteracting = false;
    //private bool _wasHeldSuccessful = true;
    //private float _fullChargeTime = 1200;
    //private Coroutine _chargeJumpRoutine;

    //private void Awake()
    //{
    //    ChargeMeterImage.gameObject.SetActive(false);
    //}

    //private void Subscribe()
    //{
    //    _controls.Movement.Jump.interactions. += ctx => OnJumpHeldStarted();
    //    _controls.Movement.Jump.performed += ctx => OnJump();
    //    _controls.Movement.Jump.interactions. += OnChargeJump;
    //    _controls.HeldJumpCancelled += OnHeldJumpCancelled;
    //}

    //private void Unsubscribe()
    //{
    //    _controls.JumpHeldStarted -= OnJumpHeldStarted;
    //    _controls.JumpPerformed -= OnJump;
    //    _controls.JumpHeldPerformed -= OnChargeJump;
    //    _controls.HeldJumpCancelled -= OnHeldJumpCancelled;
    //}

    //private void OnEnable()
    //{
    //    _controls.Movement.Enable();
    //    Subscribe();
    //}

    //private void OnDisable()
    //{
    //    _controls.Movement.Disable();
    //    Unsubscribe();
    //}



    //private void OnJumpHeldStarted()
    //{
    //    // An example, probably would be best to cache this so you do not keep creating new ones
    //    // then just reset stopwatch
    //    _chargeStopWatch = new System.Diagnostics.Stopwatch();
    //    _chargeStopWatch.Start();
    //    if (_chargeJumpRoutine != null)
    //    {
    //        StopCoroutine(_chargeJumpRoutine);
    //    }
    //    _isCharging = true;
    //    _chargeJumpRoutine = StartCoroutine(ChargeJumpMeter());
    //}

    //private void OnJump()
    //{
    //    Debug.Log("Normal Jump!");
    //    _isCharging = false;
    //    if (_chargeJumpRoutine != null)
    //    {
    //        StopCoroutine(_chargeJumpRoutine);
    //    }
    //}

    //private void OnChargeJump()
    //{
    //    _chargeStopWatch.Stop();
    //    _isCharging = false;
    //    _chargeTime = _chargeStopWatch.ElapsedMilliseconds;
    //    Debug.Log($"Charged Jump! {_chargeTime}");
    //}

    //private void OnJumpHeldStarted(float duration)
    //{
    //    ResetHeldInteractionImage();
    //    if (_heldInteractTimerRoutine != null)
    //        StopCoroutine(_heldInteractTimerRoutine);

    //    _isInteracting = true;
    //    _wasHeldSuccessful = false;
    //    _heldInteractTimerRoutine = StartCoroutine(InteractHoldTimer(duration));
    //}

    //private void OnJumpHeld()
    //{
    //    _wasHeldSuccessful = true;
    //    _isInteracting = false;
    //    Debug.Log("Held Interaction");

    //}

    //private void OnHeldJumpCancelled()
    //{
    //    _isInteracting = false;
    //    if (!_wasHeldSuccessful)
    //    {
    //        ResetHeldInteractionImage();
    //        StopCoroutine(_heldInteractTimerRoutine);
    //    }
    //}



    //private IEnumerator InteractHoldTimer(float holdDuration)
    //{
    //    float fillPercent = 0f;
    //    float currentTime = 0f;
    //    interactImage.fillAmount = fillPercent;
    //    interactImage.gameObject.SetActive(true);
    //    while (_isInteracting)
    //    {
    //        interactImage.fillAmount = fillPercent;
    //        fillPercent = currentTime / holdDuration;
    //        currentTime += Time.deltaTime;
    //        yield return new WaitForEndOfFrame();
    //    }
    //    Debug.Log($"Was Successful? {_wasHeldSuccessful}");
    //    if (_wasHeldSuccessful)
    //    {
    //        interactImage.color = Color.green;
    //        interactImage.fillAmount = 1f;
    //        yield return new WaitForSeconds(.5f);
    //        ResetHeldInteractionImage();
    //        _wasHeldSuccessful = false;
    //    }
    //    yield return null;
    //}

    //private void ResetHeldInteractionImage()
    //{
    //    interactImage.color = Color.white;
    //    interactImage.fillAmount = 0;
    //    interactImage.gameObject.SetActive(false);
    //}

    //private IEnumerator ChargeJumpMeter()
    //{
    //    ChargeMeterImage.fillAmount = 0f;
    //    ChargeMeterImage.gameObject.SetActive(true);
    //    // used to delay UI so it does not flash when you perform a normal shot
    //    yield return new WaitForSeconds(.15f);
    //    while (_isCharging)
    //    {
    //        ChargeMeterImage.fillAmount = _chargeStopWatch.ElapsedMilliseconds / _fullChargeTime;
    //        yield return new WaitForEndOfFrame();
    //    }
    //    yield return new WaitForSeconds(.25f);
    //    ChargeMeterImage.gameObject.SetActive(false);
    //    yield return null;
    //}


}
