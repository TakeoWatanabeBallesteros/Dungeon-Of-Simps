using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class UIAudioManager : MonoBehaviour
{
    public static UIAudioManager Instance;
    [SerializeField]
    [EventRef]
    private string uiClickEvent = null;
    [SerializeField]
    [EventRef]
    private string uiSelectEvent = null;
    private void Awake() {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(Instance);
        } else{
            Destroy(gameObject);
        }
    }
    public void PlayUIClickEvent(){
        RuntimeManager.PlayOneShot(uiClickEvent);
    }
    public void PlayUISelectEvent(){
        RuntimeManager.PlayOneShot(uiSelectEvent);
    }
}
