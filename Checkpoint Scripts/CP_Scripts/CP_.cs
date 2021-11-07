using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CP_Script : MonoBehaviour
{
	[Header("Declared GameObjects")]

	UnicycleController _controls;

	public Checkpoints cPList;

	private GameMaster gm;

	[SerializeField] private GameObject _cylinder;

	//private Color32 _cpColor;

	//private Renderer _cpRenderer;

	[Header("Declared Variables")]

	[SerializeField] private float _glowTimer = 0f;


	[Header("Declared States")]

	public bool _activated = false;
	public bool _collected = false;

	public void Awake()
	{
		//_cpRenderer = _cylinder.GetComponent<Renderer>();

		//_cpColor = _cylinder.GetComponent<CollectedCP>().cpCurrentColor;

		_controls = new UnicycleController();

		_controls.Gameplay.Ping.performed += ctx => Ping();
	}

	private void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Unicycle"))
		{
			gm.lastCheckpointPos = transform.position;
			gm.lastCheckpointRot = transform.rotation;
			_collected = true;
			transform.localScale = new Vector3(0, 0, 0);
		}
	}

	void Update()
    {
        #region // Renderer
        //_cpRenderer.material.EnableKeyword("_EMISSION");
        //_cpRenderer.material.SetColor("_EmissionColor", _cpColor);
        //_cpRenderer.material.SetFloat("_EmissiveIntensity", intensity - 200f);
		#endregion

        _cylinder.transform.localScale = new Vector3(0.5f, _glowTimer * .01f, 0.5f);

		if (_activated == true)
		{
			_glowTimer--;
		}
		else
		{

		}

		if (_glowTimer == 0f)
		{
			_cylinder.SetActive(false);

			_activated = false;
		}
	}

	void Ping()
	{
		_cylinder.SetActive(true);

		_glowTimer = 100f;

		_activated = true;
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