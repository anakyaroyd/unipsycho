using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Checkpoints
{
    SP_TS,
    CP_CurrentPosition,

    SP_TO,
    MidGird,
    CornGird,
    CorysDesk,
    CoffeeStation,
    Partition,
    CopyArea,
    TopOfTheLadder,
    TopOfTheLighter,

    SpawnPoint,
    CPoint_00,
    CPoint_01,
    CPoint_02,
    CPoint_03,

    CP_BowlingAlley,

}

public enum CheckpointState
{
    collected,
    visible,
    hidden
}

public enum CheckpointGroup
{
    Group00,
    Group01,
    Group02,
    Group03
}

[CreateAssetMenu]
public class CheckpointProfile : ScriptableObject
{
    // public List<Checkpoints> Group00;

    public Checkpoints cPList;
    public CheckpointState cPState;
    public CheckpointGroup cPGroup;

    public Vector3 cPPos;
    public Quaternion cPRot;

    public Color32 currentColor;


}
