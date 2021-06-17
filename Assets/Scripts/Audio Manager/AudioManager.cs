using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get; private set; }
    public StudioEventEmitter playerFootstepsConcrete;

    [SerializeField]
    [EventRef]
    private string MeleAttackEvent = null;
    [SerializeField]
    [EventRef]
    private string DoorEvent = null;
    [SerializeField]
    [EventRef]
    private string WoodHitEvent = null;
    [SerializeField]
    [EventRef]
    private string WoodDestroyEvent = null;
    [SerializeField]
    [EventRef]
    private string GirlFightEvemt = null;
    [SerializeField]
    [EventRef]
    private string GirlHitEvent = null;
    [SerializeField]
    [EventRef]
    private string PowerupEvent = null;
    [SerializeField]
    [EventRef]
    private string GirlDashEvent = null;
    /*[SerializeField]
    [EventRef]
    private string
    [SerializeField]
    [EventRef]
    private string*/

    static EventInstance doorSound, checkPointSound;
    public delegate void PlayStepsDelegate();
    public static PlayStepsDelegate PlaySteps;
    public delegate void StopStepsDelegate();
    public static StopStepsDelegate StopSteps;
    private void OnEnable() {
        PlaySteps += _PlaySteps;
        StopSteps += _StopSteps;
    }
    private void OnDisable() {
        PlaySteps -= _PlaySteps;
        StopSteps -= _StopSteps;
    }
    private void Awake() {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else{
            Destroy(gameObject);
        }
    }
    void _PlaySteps(){
        if(!playerFootstepsConcrete.IsPlaying())
            playerFootstepsConcrete.Play();
    }
    void _StopSteps(){
        if(playerFootstepsConcrete.IsPlaying())
            playerFootstepsConcrete.Stop();
    }
    public void PlayDoorEvent(GameObject door, int type){
        doorSound = FMODUnity.RuntimeManager.CreateInstance(DoorEvent);
        doorSound.setParameterByName("Door Use", type);
        doorSound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(door));
        doorSound.start();
    }
    public void PlayAttackMeleEvent(){
        RuntimeManager.PlayOneShot(MeleAttackEvent, PlayerSingleton.Instance.transform.position);
    }
    public void PlayWoodHitEvent(Vector3 pos){
        RuntimeManager.PlayOneShot(WoodHitEvent, pos);
    }
    public void PlayWoodDestroyEvent(Vector3 pos){
        RuntimeManager.PlayOneShot(WoodDestroyEvent, pos);
    }
    public void PlayGirlFightEvent(){
        RuntimeManager.PlayOneShot(GirlFightEvemt, PlayerSingleton.Instance.transform.position);
    }
    public void PlayGirlHitEvent(){
        RuntimeManager.PlayOneShot(GirlHitEvent, PlayerSingleton.Instance.transform.position);
    }
    public void PlayPowerupEvent(Vector3 pos){
        RuntimeManager.PlayOneShot(PowerupEvent, pos);
    }
    public void PlayGirlDashEvent(){
        RuntimeManager.PlayOneShot(GirlDashEvent, PlayerSingleton.Instance.transform.position);
    }
    public void StopAllSounds(){
        Bus bus = RuntimeManager.GetBus("Bus:/");
        bus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
