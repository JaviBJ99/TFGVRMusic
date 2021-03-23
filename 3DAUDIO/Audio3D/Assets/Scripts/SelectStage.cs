using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{


    public GameObject suelo;
    public GameObject techo;


    Vector3 sueloScaleOriginal;
    Vector3 sueloPosOriginal;
    Vector3 techoScaleOriginal;
    Vector3 techoPosOriginal;





    public int stageNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
       sueloScaleOriginal = suelo.transform.localScale;
       sueloPosOriginal = suelo.transform.localPosition;
       techoScaleOriginal = techo.transform.localScale;
       techoPosOriginal = techo.transform.localPosition;
    }


    // Update is called once per frame
    void Update()
    {
      

    }


    public void Select()
    {
       

    }
    
}
