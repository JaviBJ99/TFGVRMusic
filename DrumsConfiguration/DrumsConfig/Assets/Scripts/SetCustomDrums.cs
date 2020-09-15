using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCustomDrums : MonoBehaviour
{
    // Start is called before the first frame update


    public CustomDrums customDrums;

    int numToms;

    int nFtoms;

    int nCrashes;

    public GameObject tom1;

    public GameObject tom2;

    public GameObject tom3;

    public GameObject[] toms = new GameObject[3];

    void Start()
    {
        getNumber();

        Debug.Log("HAS ESTOS TOMS "+ numToms);
        setToms(numToms);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setToms(int t)
    {
        Debug.Log("EHHHHHHHHHHHH");
        toms[0] = tom1;
        toms[1] = tom2;
        toms[2] = tom3;

        for (int i = 0; i < t; i++)
        {
            toms[i].transform.position = Positions.tomsPos[i];
            Debug.Log("BRO");
        }
    }
    
    public void getNumber()
    {
        numToms = Positions.nToms;
        

    }

    

}
