using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ModifyStage : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StageConfigurations.stageId = 1;
    }
    public void SelectStage(float n)
    {
        StageConfigurations.stageId = (int)n;

    }
}
