using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject personaje;


    Vector3 posOriginal;

 
    void Start()
    {
        posOriginal = personaje.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            SelectPos(1);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SelectPos(2);
        }


    }


    public void SelectPos(int Stagenumber)
    {
        switch (Stagenumber)

        {
            case 1:
                personaje.transform.position = posOriginal;
                break;

            case 2:
                personaje.transform.position = new Vector3(18.59f, 4.005f, 0f);
                break;
        }
    }
}
