using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SelectionBase]
public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
  
    void Start()
    { 
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
        transform.rotation = gm.lastCheckpointRot;
    }
    
}