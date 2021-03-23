using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomHiHatSound : MonoBehaviour
{
    // Start is called before the first frame update

    public TopHihatSound top;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            top.isOpen = !top.isOpen;

        }

    }
}

