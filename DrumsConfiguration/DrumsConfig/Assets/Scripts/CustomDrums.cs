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
        ftoms = (int)f;

    }

    public void changeCrasesh(float c)
    {
        crashes = (int)c;
    }

    
}
