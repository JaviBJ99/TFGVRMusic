using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomHiHatSound : MonoBehaviour
{
    // Start is called before the first frame update

    public TopHihatSound top;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            top.isOpen = !top.isOpen;

        }

    }
}

