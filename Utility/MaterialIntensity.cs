using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MaterialIntensity : MonoBehaviour
{
    UnicycleController _controls;
    
    [Header("Material Intensity")]

    [SerializeField] private Material _seatMat;
    public Color _emissionColorValue;
    public float desiredValue = 5000f;
    public float _intensity;

    public bool _crouched;

    [SerializeField] private float _fullCharge = 20f;
    [SerializeField] private float _emissionTimer;

    private void Awake()
    {
        _controls = new UnicycleController();

        _controls.Gameplay.Crouch.performed += ctx => Crouch();
        _controls.Gameplay.Launch.performed += ctx => Launch();

        
    }

    void Start()
    {
        _emissionTimer = 0f;
    }

    // Update is called once per frame
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
        _seatMat.SetVector("_EmissionColor", _emissionColorValue * _intensity);

        if (_crouched && _emissionTimer >= _fullCharge)
        {
            _intensity = 5000f;
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
