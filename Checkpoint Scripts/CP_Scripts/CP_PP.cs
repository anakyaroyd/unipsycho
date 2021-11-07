using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP_PP : MonoBehaviour
{
	[Header("Declared GameObjects")]

	Scr_InputController _input;

	public CheckpointProfile cPProfile;
	public Checkpoints cPList;
	public CheckpointGroup cPGroup;
	public CheckpointState cPState;

	private GameMaster gm;

	public GameObject _cylinder;

	private Renderer _cpRenderer;

	public Scr_CheckpointReached _checkpointReached;

	[Header("Checkpoint Color")]
	public Color32 currentColor;
    public Color32 cpNewColor = new Color32(25, 255, 0, 18);
    public Color32 cpOldColor = new Color32(255, 0, 237, 18);

	[Header("Declared Variables")]

	[SerializeField] private float _glowTimer = 0f;

	[Header("Declared States")]

	public bool _activated = false;
	public bool _collected = false;

	public float _ping;

	public void Awake()   {
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

		_cpRenderer = _cylinder.GetComponent<Renderer>();

		_input = GameObject.FindGameObjectWithTag("GM").GetComponent<Scr_InputController>();
	}

	private void OnTriggerEnter(Collider other){
		if (other.CompareTag("Unicycle")){
            gm.lastCheckpointPos = transform.position;
			gm.lastCheckpointRot = transform.rotation;
			gm.currentCP = this.cPList;
			
			transform.localScale = new Vector3(0, 0, 0);

            if (_collected == false) {
                //_checkpointReached.CheckpointReached();
				cPState = CheckpointState.collected;
                _collected = true;
			}
		}
	}

	void Update()
	{
		_ping = _input.PingCheckpointInput;

        if (_input.PingCheckpointInput == 1f) {
			Ping();
		}

		#region // Renderer
		//_cpRenderer.material.EnableKeyword("_EMISSION");
		//_cpRenderer.material.SetColor("_EmissionColor", _cpColor);
		//_cpRenderer.material.SetFloat("_EmissiveIntensity", intensity - 200f);
		#endregion

		_cylinder.transform.localScale = new Vector3(0.5f, _glowTimer * .01f, 0.5f);

		if (_activated == true)	{
			_glowTimer--;
		}	else
		{
			_glowTimer = 0f;
		}

		if (_glowTimer == 0f){
			_cylinder.SetActive(false);

			_activated = false;
		}
        #region // Checkpoint States
        if (cPState == CheckpointState.hidden)   {

        }

		if (cPState == CheckpointState.visible){

		}

		if (cPState == CheckpointState.collected){

		}
		#endregion
	}

	void Ping()	{
		_cylinder.SetActive(true);
		_glowTimer = 100f;
		_activated = true;
		_input.PingCheckpointInput = 0f;
	}
}