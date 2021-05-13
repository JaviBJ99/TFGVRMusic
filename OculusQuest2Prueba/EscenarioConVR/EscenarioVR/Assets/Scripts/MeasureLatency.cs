using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureLatency : MonoBehaviour
{

    int bufferLength, numBuffers;
    void Update()
    {
        AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);

        Debug.Log(bufferLength);
        Debug.Log(numBuffers);

    }


}
