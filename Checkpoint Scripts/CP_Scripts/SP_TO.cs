using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_TO : MonoBehaviour
{
	[Header("Declared GameObjects")]

	public Checkpoints cPList;

	private GameMaster gm;

	[Header("Declared States")]

	public bool _activated = false;
	public bool _collected = false;

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

}
