using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetModifyStage : MonoBehaviour
{

    AudioSource audiosource;
    AudioReverbFilter audiofilter;

    public GameObject studio, arena, church;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiofilter = GetComponent<AudioReverbFilter>();
        SetStage(StageConfigurations.stageId);
        
    }

    void SetStage(int id)
    {
        switch (id)
        {
            case 1:
                studio.SetActive(true);
                SetStudioMaster();
                break;

            case 2:
                arena.SetActive(true);
                SetArenaMaster();
                break;

            case 3:
                church.SetActive(true);
                SetChurchMaster();
                break;
        }

    }

    void SetStudioMaster()
    {
        audiofilter.reverbPreset = AudioReverbPreset.Room;
    }
    void SetArenaMaster()
    {
        audiofilter.reverbPreset = AudioReverbPreset.Arena;
    }
    void SetChurchMaster()
    {
        audiofilter.reverbPreset = AudioReverbPreset.Concerthall;
    }

}
