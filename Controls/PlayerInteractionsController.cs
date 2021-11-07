using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

public class PlayerInteractionsController : MonoBehaviour
{
//    [SerializeField]
//    private PlayerControls _playerControls;

//    public Image interactImage;
//    public Image ChargeMeterImage;


//    // Testing
//    private bool _isCharging;
//    private float _chargeTime;
//    private System.Diagnostics.Stopwatch _chargeStopWatch;
//    private Coroutine _heldInteractTimerRoutine;
//    private bool _isInteracting = false;
//    private bool _wasHeldSuccessful = true;
//    private float _fullChargeTime = 650;
//    private Coroutine _chargeFireRoutine;
    
//    private void Awake(){
//        ChargeMeterImage.gameObject.SetActive(false);
//    }

//    private void Subscribe()
//    {
//        _playerControls.FireHeldStarted += OnFireHeldStarted;
//        _playerControls.FirePerformed += OnFire;
//        _playerControls.FireHeldPerformed += OnChargeFire;

//        _playerControls.HeldInteractStarted += OnInteractHeldStarted;
//        _playerControls.HeldInteractPerformed += OnInteractHeld;
//        _playerControls.InteractPerformed += OnInteract;
//        _playerControls.HeldInteractionCancelled += OnHeldInteractCancelled;
//    }

//    private void Unsubscribe()
//    {
//        _playerControls.FireHeldStarted -= OnFireHeldStarted;
//        _playerControls.FirePerformed -= OnFire;
//        _playerControls.FireHeldPerformed -= OnChargeFire;

//        _playerControls.HeldInteractStarted -= OnInteractHeldStarted;
//        _playerControls.HeldInteractPerformed -= OnInteractHeld;
//        _playerControls.InteractPerformed -= OnInteract;
//        _playerControls.HeldInteractionCancelled -= OnHeldInteractCancelled;
//    }

//    private void OnEnable()
//    {
//        _playerControls.GetComponent<PlayerControls>();
//        Subscribe();
//    }

//    private void OnDisable()
//    {
//       Unsubscribe();
//    }

    

//    private void OnFireHeldStarted()
//    {
//        // An example, probably would be best to cache this so you do not keep creating new ones
//        // then just reset stopwatch
//        _chargeStopWatch = new System.Diagnostics.Stopwatch();
//        _chargeStopWatch.Start();
//        if (_chargeFireRoutine != null)
//        {
//            StopCoroutine(_chargeFireRoutine);
//        }
//        _isCharging = true;
//        _chargeFireRoutine = StartCoroutine(ChargeFireMeter());
//    }

//    private void OnFire()
//    {
//        Debug.Log("Normal Fire!");
//        _isCharging = false;
//        if (_chargeFireRoutine != null)
//        {
//            StopCoroutine(_chargeFireRoutine);
//        }
//    }

//    private void OnChargeFire()
//    {
//        _chargeStopWatch.Stop();
//        _isCharging = false;
//        _chargeTime = _chargeStopWatch.ElapsedMilliseconds;
//    }

//    private void OnInteract()
//    {
//        Debug.Log("Normal Interaction");

//    }

//    private void OnInteractHeldStarted(float duration)
//    {
//        ResetHeldInteractionImage();
//        if(_heldInteractTimerRoutine != null)
//            StopCoroutine(_heldInteractTimerRoutine);

//        _isInteracting = true;
//        _wasHeldSuccessful = false;
//        _heldInteractTimerRoutine = StartCoroutine(InteractHoldTimer(duration));
//    }

//    private void OnInteractHeld()
//    {
//        _wasHeldSuccessful = true;
//        _isInteracting = false;
//        Debug.Log("Held Interaction");
        
//    }

//    private void OnHeldInteractCancelled()
//    {
//        _isInteracting = false;
//        if (!_wasHeldSuccessful)
//        {
//            ResetHeldInteractionImage();
//            StopCoroutine(_heldInteractTimerRoutine);
//        }
//    }

    

//    private IEnumerator InteractHoldTimer(float holdDuration)
//    {
//        float fillPercent = 0f;
//        float currentTime = 0f;
//        interactImage.fillAmount = fillPercent;
//        interactImage.gameObject.SetActive(true);
//        while (_isInteracting)
//        {
//            interactImage.fillAmount = fillPercent;
//            fillPercent = currentTime / holdDuration;
//            currentTime += Time.deltaTime;
//            yield return new WaitForEndOfFrame();
//        }
//        Debug.Log($"Was Successful? {_wasHeldSuccessful}");
//        if (_wasHeldSuccessful)
//        {
//            interactImage.color = Color.green;
//            interactImage.fillAmount = 1f;
//            yield return new WaitForSeconds(.5f);
//            ResetHeldInteractionImage();
//            _wasHeldSuccessful = false;
//        }
//        yield return null;
//    }

//    private void ResetHeldInteractionImage()
//    {
//        interactImage.color = Color.white;
//        interactImage.fillAmount = 0;
//        interactImage.gameObject.SetActive(false);
//    }

//    private IEnumerator ChargeFireMeter()
//    {
//        ChargeMeterImage.fillAmount = 0f;
//        ChargeMeterImage.gameObject.SetActive(true);
//        // used to delay UI so it does not flash when you perform a normal shot
//        yield return new WaitForSeconds(.15f);  
//        while (_isCharging)
//        {
//            ChargeMeterImage.fillAmount = _chargeStopWatch.ElapsedMilliseconds / _fullChargeTime;
//            yield return new WaitForEndOfFrame();
//        }
//        yield return new WaitForSeconds(.25f);
//        ChargeMeterImage.gameObject.SetActive(false);
//        yield return null;
//    }


}
