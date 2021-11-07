using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatGlow : MonoBehaviour
{
    UnicycleController _controls;
    [SerializeField] GameObject _uni;

    [Header("Material Intensity")]

    [SerializeField] private Material _seatMat;

    public Renderer rend;

    public Color _emissionColorValue;
    public float desiredValue = 5000f;
    public float _intensity;

    public bool _crouched;

    [SerializeField] private float _fullCharge = 20f;
    [SerializeField] private float _emissionTimer;

    private void Awake()
    {

       // _emissionTimer = _uni.GetComponent<Jump>()._groundTimer;

        _controls = new UnicycleController();

        _controls.Gameplay.Crouch.performed += ctx => Crouch();
        _controls.Gameplay.Launch.performed += ctx => Launch();

        rend = GetComponent<Renderer>();

        //_seatMat = rend
;
    }

    void Start()
    {
        _emissionTimer = 0f;
    }

    void Update()
    {
        _intensity = _emissionTimer * 25f;



        if (_crouched)
        {
            _emissionTimer++;
        }
    }

    void FixedUpdate()
    {
        _seatMat.SetFloat("_EmissiveIntensity", _intensity);
        _seatMat.SetFloat("_UseEmissiveIntensity", 1f);

        if (_emissionTimer >= _fullCharge)
        {
            _intensity = desiredValue;
        }

        if (_intensity < 0)
        {
            _intensity = 0;
        }

        if (_emissionTimer == 0f)
        {
            _intensity = 0f;
        }
    }
    private void Crouch()
    {
        _crouched = true;

    }

    private void Launch()
    {
        _intensity = 0f;
        _emissionTimer = 0f;
        _crouched = false;
    }

    void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
