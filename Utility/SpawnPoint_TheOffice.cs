using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint_TheOffice : MonoBehaviour
{
	private GameMaster gm;

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
			
		}
	}

}