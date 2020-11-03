using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 actualPos = new Vector3(0, 0, 0);
    Vector3 lastPos = new Vector3(0, 0, 0);
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualPos = obj.transform.position;
        lastPos = actualPos;
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DrumPart")
        {
            Debug.Log("EHHH");
            obj.transform.position = lastPos;
            
            //this.GetComponent.
        }
    }


}
