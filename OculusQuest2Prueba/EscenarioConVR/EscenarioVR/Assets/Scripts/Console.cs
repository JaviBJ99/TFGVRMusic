using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    Text message;
    string length, num;

    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();

       


    }

    // Update is called once per frame
    void Update()
    {
     

        
    }

    public void showText(int l, int n)
    {
        length = l.ToString();
        num = n.ToString();
        message.text = "lenght " + length + " num " + num;


    }
}
