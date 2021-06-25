using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using FMODUnity;
using TMPro;

public class PlayerSettings : MonoBehaviour
{
    public static PlayerSettings playerSettings;
    
    /*[SerializeField]
    private InputField field = null;*/
    [SerializeField]
    private string busPath = "";
    [SerializeField]
    private string busMusicPath = "";
    [SerializeField]
    private string busGameplayPath = "";
    FMOD.ChannelGroup group;
    private FMOD.Studio.Bus bus, busMusic, busGameplay;
    TMP_Dropdown resDropdown, qualityDropdown;
    Slider volumeSlider, volumeMusicSlider, volumeGameplaySlider;
    Toggle fullScreen;
    List<Resolution> resolutions;

    private void OnEnable() {
        PlayerAbilities.OnSlowMo += DownPitch;
        PlayerAbilities.FinishSlowMo += ResetPitch;
    }
    private void OnDisable() {
        PlayerAbilities.OnSlowMo -= DownPitch;
        PlayerAbilities.FinishSlowMo -= ResetPitch;
    }
    // Start is called before the first frame update
    private void Awake() {
        if(playerSettings == null){
            DontDestroyOnLoad(gameObject);
            playerSettings = this;
        } else if(playerSettings != this){
            Destroy(gameObject);
        }
    }
    private void Start() {
        fullScreen = GameObject.FindGameObjectWithTag("FullScreen").GetComponent<Toggle>();
        if(PlayerPrefs.GetInt("firstTime")==0){
            PlayerPrefs.SetInt("firstTime", 1);
            PlayerPrefs.SetInt("window", 1);
            Screen.fullScreen = true;
            fullScreen.isOn = true;
            resolutions = GetResolutions();
            resDropdown = GameObject.FindGameObjectWithTag("Resolutions").GetComponent<TMP_Dropdown>();
            resDropdown.ClearOptions();
            List<string> options = new List<string>();
            PlayerPrefs.SetInt("resIndx", resolutions.Count-1);
            for (int i = 0; i < resolutions.Count; i++)
            {
                string option = resolutions[i].width + "x" + resolutions[i].height;
                options.Add(option);
            }
            resDropdown.AddOptions(options);
            resDropdown.value = PlayerPrefs.GetInt("resIndx");
            resDropdown.RefreshShownValue();
            ChangeRes(PlayerPrefs.GetInt("resIndx"));
            qualityDropdown = GameObject.FindGameObjectWithTag("Quality").GetComponent<TMP_Dropdown>();
            PlayerPrefs.SetInt("qualityIndx", 2);
            qualityDropdown.value = PlayerPrefs.GetInt("qualityIndx");
            qualityDropdown.RefreshShownValue();
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualityIndx"));
            volumeSlider = GameObject.FindGameObjectWithTag("Volume").GetComponent<Slider>();
            PlayerPrefs.SetFloat("volume", 1);
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
            bus.setVolume(PlayerPrefs.GetFloat("volume"));
            volumeMusicSlider = GameObject.FindGameObjectWithTag("VolumeMusic").GetComponent<Slider>();
            PlayerPrefs.SetFloat("volumeMusic", 1);
            volumeMusicSlider.value = PlayerPrefs.GetFloat("volumeMusic");
            busMusic.setVolume(PlayerPrefs.GetFloat("volumeMusic"));
            volumeGameplaySlider = GameObject.FindGameObjectWithTag("VolumeGameplay").GetComponent<Slider>();
            PlayerPrefs.SetFloat("volumeGameplay", 1);
            volumeGameplaySlider.value = PlayerPrefs.GetFloat("volumeGameplay");
            busGameplay.setVolume(PlayerPrefs.GetFloat("volumeGameplay"));
        }else{
            if(PlayerPrefs.GetInt("window")==1){
            Screen.fullScreen = true;
            fullScreen.isOn = true;
            }
            resolutions = GetResolutions();
            resDropdown = GameObject.FindGameObjectWithTag("Resolutions").GetComponent<TMP_Dropdown>();
            resDropdown.ClearOptions();
            List<string> options = new List<string>();
            PlayerPrefs.SetInt("resIndx", resolutions.Count-1);
            for (int i = 0; i < resolutions.Count; i++)
            {
                string option = resolutions[i].width + "x" + resolutions[i].height;
                options.Add(option);
            }
            resDropdown.AddOptions(options);
            resDropdown.value = PlayerPrefs.GetInt("resIndx");
            resDropdown.RefreshShownValue();
            ChangeRes(PlayerPrefs.GetInt("resIndx"));
            qualityDropdown = GameObject.FindGameObjectWithTag("Quality").GetComponent<TMP_Dropdown>();
            qualityDropdown.value = PlayerPrefs.GetInt("qualityIndx");
            qualityDropdown.RefreshShownValue();
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualityIndx"));
            volumeSlider = GameObject.FindGameObjectWithTag("Volume").GetComponent<Slider>();
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
            bus.setVolume(PlayerPrefs.GetFloat("volume"));
            volumeMusicSlider = GameObject.FindGameObjectWithTag("VolumeMusic").GetComponent<Slider>();
            volumeMusicSlider.value = PlayerPrefs.GetFloat("volumeMusic");
            busMusic.setVolume(PlayerPrefs.GetFloat("volumeMusic"));
            volumeGameplaySlider = GameObject.FindGameObjectWithTag("VolumeGameplay").GetComponent<Slider>();
            volumeGameplaySlider.value = PlayerPrefs.GetFloat("volumeGameplay");
            busGameplay.setVolume(PlayerPrefs.GetFloat("volumeGameplay"));
        }  
    }
    public void SetVolune(float volume){
        bus.setVolume(volume);
        PlayerPrefs.SetFloat("volume", volume);
    }
    public void SetMusicVolune(float volume){
        busMusic.setVolume(volume);
        PlayerPrefs.SetFloat("volumeMusic", volume);
    }
    public void SetGameplayVolune(float volume){
        busGameplay.setVolume(volume);
        PlayerPrefs.SetFloat("volumeGameplay", volume);
    }
    void DownPitch(){
        bus.getChannelGroup(out group);
        group.setPitch(.5f);
        group.getPitch(out float ap);
    }
    void ResetPitch(){
        bus.getChannelGroup(out group);
        group.setPitch(1);
    }
    public void SetQuality(int indx){
        QualitySettings.SetQualityLevel(indx);
        PlayerPrefs.SetInt("qualityIndx", indx);
    }
    public void ChangeRes(int indx){
        Resolution res = resolutions[indx];
        if(PlayerPrefs.GetInt("window")==1) Screen.SetResolution(res.width, res.height, true);
        else Screen.SetResolution(res.width, res.height, false);
        PlayerPrefs.SetInt("resIndx", indx);
    }
    public void SetFullScreen(bool fullScreen){
        #if UNITY_STANDALONE
		Screen.fullScreen = fullScreen;
		if(fullScreen){
            PlayerPrefs.SetInt("window", 1);
		}else{
            PlayerPrefs.SetInt("window", 0);
		}
        #endif
	}
    public void Save(){
        PlayerPrefs.Save();
    }
    List<Resolution> GetResolutions() {
     //Filters out all resolutions with low refresh rate:
     Resolution[] resolutions = Screen.resolutions;
     HashSet<System.ValueTuple<int, int>> uniqResolutions = new HashSet<System.ValueTuple<int, int>>();
     Dictionary<System.ValueTuple<int, int>, int> maxRefreshRates = new Dictionary<System.ValueTuple<int, int>, int>();
     for (int i = 0; i < resolutions.GetLength(0); i++) {
         //Add resolutions (if they are not already contained)
         System.ValueTuple<int, int> resolution = new System.ValueTuple<int, int>(resolutions[i].width, resolutions[i].height);
         uniqResolutions.Add(resolution);
         //Get highest framerate:
         if (!maxRefreshRates.ContainsKey(resolution)) {
             maxRefreshRates.Add(resolution, resolutions[i].refreshRate);
         } else {
             maxRefreshRates[resolution] = resolutions[i].refreshRate;
         }
     }
     //Build resolution list:
     List<Resolution> uniqResolutionsList = new List<Resolution>(uniqResolutions.Count);
     foreach (System.ValueTuple<int, int> resolution in uniqResolutions) {
         Resolution newResolution = new Resolution();
         newResolution.width = resolution.Item1;
         newResolution.height = resolution.Item2;
         if(maxRefreshRates.TryGetValue(resolution, out int refreshRate)) {
             newResolution.refreshRate = refreshRate;
         }
         uniqResolutionsList.Add(newResolution);
     }
     return uniqResolutionsList;
    }
    void StartRes(){
        if(PlayerPrefs.GetInt("firstTime")==0){

        } else{

        }
    }
    void StartVolume(){
        bus = RuntimeManager.GetBus(busPath);
        busMusic = RuntimeManager.GetBus(busMusicPath);
        busGameplay = RuntimeManager.GetBus(busGameplayPath);
        if(PlayerPrefs.GetInt("firstTime")==0){
        }
    }
    void StartFullScreen(){
        if(PlayerPrefs.GetInt("firstTime")==0){
        }
    }
}
