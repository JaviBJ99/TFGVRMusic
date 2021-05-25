using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomDrums : MonoBehaviour
{

    public void Start()
    {
        Positions.nToms = 0;
        Positions.nFToms = 0;
        Positions.nCrashes = 0;
    }
    
    public void changeToms(float n)
    {
        Positions.nToms= (int)n;
    }

    public void changeFToms(float f)
    {
        Positions.nFToms = (int)f;
    }

    public void changeCrashes(float c)
    {
        Positions.nCrashes = (int)c;
    }

    
}
