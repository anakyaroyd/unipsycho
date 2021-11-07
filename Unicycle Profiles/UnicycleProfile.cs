using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UniColorSwatch
{
    BurntOrangeSurprise,
    BlueberryOrangeSuperFizzyPop,
    BabyBlueSedan

}

[CreateAssetMenu]
public class UnicycleProfile : ScriptableObject
{
    public UniColorSwatch swatch;


}
