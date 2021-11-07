using UnityEngine;

public class UniAcc : MonoBehaviour
{
    UnicycleController _controls;

    public Rigidbody _rb;

    [SerializeField] private float _pedal;
    //[SerializeField] private float _pedalPower = 3000f;

    public float wheelVel;

    [SerializeField] private float _speed;
    [SerializeField] private float _angularSpeed;

    private void Awake() 
    {
        _rb = GetComponent<Rigidbody>();
        _controls = new UnicycleController();

        _controls.Gameplay.Pedal.performed += ctx => _pedal = ctx.ReadValue<float>();
        _controls.Gameplay.Pedal.canceled += ctx => _pedal = ctx.ReadValue<float>();

    }

    private void FixedUpdate()
    {
        _speed = _rb.velocity.magnitude;
        _angularSpeed = _rb.angularVelocity.magnitude;

        _rb.maxAngularVelocity = 20f;
        _rb.AddTorque(Vector3.right, ForceMode.Acceleration);

    
    }


     private void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
}
