using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class EnemyAudioManager : MonoBehaviour
{
    public static EnemyAudioManager Instance {get; private set; }
    [SerializeField]
    [EventRef]
    private string MiniMobEvent = null;
    [SerializeField]
    [EventRef]
    private string WitchEvent = null;
    [SerializeField]
    [EventRef]
    private string GolemEvent = null;
    [SerializeField]
    [EventRef]
    private string SunEvent = null;


    private void Awake() {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else{
            Destroy(gameObject);
        }
    }
    public void PlayMiniMobEvent(int state, Vector3 pos){
        FMOD.Studio.EventInstance audio = FMODUnity.RuntimeManager.CreateInstance(MiniMobEvent);
        audio.start();
        audio.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(pos));
        audio.setParameterByName("State", state);
    }
    public void PlayWitchEvent(int state, Vector3 pos){
        FMOD.Studio.EventInstance audio = FMODUnity.RuntimeManager.CreateInstance(WitchEvent);
        audio.start();
        audio.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(pos));
        audio.setParameterByName("State", state);
    }
    public void PlayGolemEvent(int state, Vector3 pos){
        FMOD.Studio.EventInstance audio = FMODUnity.RuntimeManager.CreateInstance(GolemEvent);
        audio.start();
        audio.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(pos));
        audio.setParameterByName("State", state);
    }
    public void PlaySunEvent(int state, Vector3 pos){
        FMOD.Studio.EventInstance audio = FMODUnity.RuntimeManager.CreateInstance(SunEvent);
        audio.start();
        audio.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(pos));
        audio.setParameterByName("State", state);
    }
}
