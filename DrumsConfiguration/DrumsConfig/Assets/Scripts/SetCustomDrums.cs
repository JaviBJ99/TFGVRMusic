using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCustomDrums : MonoBehaviour
{
    // Start is called before the first frame update


    public CustomDrums customDrums;

    int numToms;

    int numFtoms;

    int numCrashes;

    public GameObject tom1, tom2, tom3, ftom1, ftom2, crash1, crash2, crash3, snare, hihat, kick, ride;

    public GameObject[] toms = new GameObject[3];

    public GameObject[] crashes = new GameObject[3];

    public GameObject[] ftoms = new GameObject[2];

    void Start()
    {
        getNumber();

        setDrums();
        setToms(numToms);
        setFToms(numFtoms);
        setCrashes(numCrashes); 



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setToms(int t)
    {
        
        toms[0] = tom1;
        toms[1] = tom2;
        toms[2] = tom3;

        for (int i = 0; i < t; i++)
        {
            toms[i].transform.position = Positions.tomsPos[i];
            
        }
    }

    public void setCrashes(int c)
    {
        crashes[0] = crash1;
        crashes[1] = crash2;
        crashes[2] = crash3;


        for (int i = 0; i < c; i++)
        {
            crashes[i].transform.position = Positions.crashesPos[i];
           
        }

    }

    public void setDrums()
    {
        snare.transform.position = Positions.snarePos;
        kick.transform.position = Positions.kickDrumPos;
        //kick.transform.Rotate(Positions.kickDrumRot[0], Positions.kickDrumRot[1], Positions.kickDrumRot[2], Space.Self);
        hihat.transform.position = Positions.hihattopPos;
        ride.transform.position = Positions.ridePos;
    }

    public void setFToms(int f)
    {
        ftoms[0] = ftom1;
        ftoms[1] = ftom2;

        for (int i = 0; i < f; i++)
        {
            ftoms[i].transform.position = Positions.ftomsPos[i];

        }


    }
    
    public void getNumber()
    {
        numToms = Positions.nToms;

        numFtoms = Positions.nFToms;

        numCrashes = Positions.nCrashes;

    }

    

}
