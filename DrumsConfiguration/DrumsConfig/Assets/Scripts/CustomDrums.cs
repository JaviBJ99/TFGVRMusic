using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomDrums : MonoBehaviour
{
    public int toms;

    public int ftoms;

    public int crashes;

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
