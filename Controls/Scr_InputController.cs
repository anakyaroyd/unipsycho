using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_InputController : MonoBehaviour {

    private PlayerController _controls;

    #region // Get/Set Input Variables

    public float PedalInput { get; private set; }

    public float LeanLRInput { get; private set; }
    public float TiltFBInput { get; private set; }

    public float TurnInput { get; private set; }

    public Vector2 ShiftWeightInput { get; private set; }

    public Vector2 AirborneMovementInput { get; private set; }
    public Vector2 AirborneRotationInput { get; private set; }

    public float CrouchInput { get; private set; }
    public float LaunchInput { get; private set; }
    public float JumpCancelInput { get; private set; }

    public float PingCheckpointInput { get; set; }

    public int ResetInput { get; private set; }

    public float SelectInput { get; private set; }
    public Vector2 NavigateInput { get; private set; }
    public float PauseInput { get; private set; }
    public float BackInput { get; private set; }

    //public int ResetInputRotPos { get; private set; }
    //GameObject [] uniRB;

    #endregion

    private void Awake() {
        _controls = new PlayerController();

        #region // Pedal Input

        _controls.Gameplay.Pedal.performed += ctx => PedalInput = ctx.ReadValue<float>();
        _controls.Gameplay.Pedal.canceled += ctx => PedalInput = 0f;

        #endregion

        #region // Rotation Input

        _controls.Gameplay.TurnLR.performed += ctx => TurnInput = ctx.ReadValue<float>();
        _controls.Gameplay.TurnLR.canceled += ctx => TurnInput = 0f;

        _controls.Gameplay.LeanLR.performed += ctx => LeanLRInput = ctx.ReadValue<float>();
        _controls.Gameplay.LeanLR.canceled += ctx => LeanLRInput = 0f;

        _controls.Gameplay.TiltFB.performed += ctx => TiltFBInput = ctx.ReadValue<float>();
        _controls.Gameplay.TiltFB.canceled += ctx => TiltFBInput = 0f;

        _controls.Gameplay.ShiftWeight.performed += ctx => ShiftWeightInput = ctx.ReadValue<Vector2>();
        _controls.Gameplay.ShiftWeight.canceled += ctx => ShiftWeightInput = ctx.ReadValue<Vector2>();

        #endregion

        #region // Jumping Input

        _controls.Gameplay.Crouch.performed += ctx => CrouchInput = ctx.ReadValue<float>();
        _controls.Gameplay.Crouch.canceled += ctx => CrouchInput = 0f;

        _controls.Gameplay.Launch.started += ctx => LaunchInput = ctx.ReadValue<float>();

        _controls.Gameplay.JumpCancel.performed += ctx => JumpCancelInput = ctx.ReadValue<float>();
        _controls.Gameplay.JumpCancel.canceled += ctx => JumpCancelInput = 0f;
        #endregion

        #region // Airborne Movement/Rotation

        _controls.Gameplay.AirMovement.performed += ctx => AirborneMovementInput = ctx.ReadValue<Vector2>();
        _controls.Gameplay.AirMovement.canceled += ctx => AirborneMovementInput = Vector2.zero;

        _controls.Gameplay.AirRotation.performed += ctx => AirborneRotationInput = ctx.ReadValue<Vector2>();
        _controls.Gameplay.AirRotation.canceled += ctx => AirborneRotationInput = Vector2.zero;

        #endregion

        #region // Misc. Input

        _controls.Gameplay.Reset.performed += ctx => ResetUni();

        _controls.Gameplay.Ping.performed += ctx => PingCheckpointInput = ctx.ReadValue<float>();

        #endregion

        #region // UI Input

        _controls.UI.Select.started += ctx => SelectInput = ctx.ReadValue<float>();

        _controls.UI.Pause.started += ctx => PauseInput = ctx.ReadValue<float>();

        _controls.UI.Back.started += ctx => BackInput = ctx.ReadValue<float>();

        _controls.UI.Navigate.performed += ctx => NavigateInput = ctx.ReadValue<Vector2>();
        _controls.UI.Navigate.canceled += ctx => NavigateInput = Vector2.zero;

        #endregion
    }

    public void ResetUni() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnEnable() {
        _controls.Enable();
    }

    private void OnDisable() {
        _controls.Disable();   
    }
}

//void ResetUniRotPos() {
//Debug.Log("uni  Reset");
//uniRB.position = new Vector3(0, 0, 0);
//uniRB.rotation = new Quaternion(0f, 0f, 0f, 0f);
//uniRB.velocity = Vector3.zero;

//Debug.Log("uni  Reset");
//foreach (var rb in uniRB) {
//    rb.GetComponent<Rigidbody>().velocity = Vector3.zero;

//    rb.GetComponent<Rigidbody>().transform.position = new Vector3(0, 0, 0);
//    rb.GetComponent<Rigidbody>().transform.rotation = new Quaternion(0f, 0f, 0f, 1f);
//}
//}