using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class GameFlowControler : MonoBehaviour
{
    static GameFlowControler instance;
    bool OnPause = false;
    public TMP_Text count;
    List<string> levelNames;
    Animator transitionsManager;
    public Slider slider;
    public delegate void OnMenuDelegate();
    public static OnMenuDelegate OnMenu;
    public delegate void OnGameDelegate();
    public static OnGameDelegate OnGame;
    public delegate void RestartDelegate();
    public static RestartDelegate Restart;

    void OnEnable(){
        PlayerHealth.OnDeath += DeathMenu;
    }
    void OnDisable(){
        PlayerHealth.OnDeath -= DeathMenu;
    }
    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        } else{
            Destroy(gameObject);
        }
        levelNames = new List<string>();
        levelNames.Add("MainMenu");
        levelNames.Add("Level 01");
        levelNames.Add("Level 02");
        levelNames.Add("Level 03");
    }
    void Start() {
        transitionsManager = GetComponent<Animator>();
        Controls.controls.PlayerControls.TogglePause.started += _=>EnablePauseMenu();
        Controls.controls.MenuControls.TogglePause.started += _=>ReturnGame();
        #if UNITY_EDITOR
        if(SceneManager.GetActiveScene().buildIndex!=0){
            Controls.controls.PlayerControls.Enable();
            OnGame?.Invoke();
        }
        else{
            Controls.controls.MainMenuControls.Enable();
            OnMenu.Invoke();
        }
        #endif
        #if UNITY_STANDALONE
        Controls.controls.MainMenuControls.Enable();
        OnMenu.Invoke();
        #endif
    }
    public void PlayGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_PlayGame());
    }
    IEnumerator _PlayGame(){
        Controls.controls.PlayerControls.Enable();
        Controls.controls.MainMenuControls.Disable();
        transitionsManager.SetTrigger("MainMenu-Loader");
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[1]);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        transitionsManager.SetTrigger("Loader-PlayerUI");
        operation.allowSceneActivation = true;
        OnGame?.Invoke();
    }
    public void EnablePauseMenu(){
        OnPause = true;
        UIAudioManager.Instance.PlayUIClickEvent();
        AudioManager.StopSteps?.Invoke();
        Controls.controls.PlayerControls.Disable();
        Controls.controls.MenuControls.Enable();
        OnMenu?.Invoke();
        transitionsManager.SetTrigger("PlayerUI-PauseMenu");
        Time.timeScale = 0f;
    }
    public void ReturnGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(OnPause){
        Controls.controls.PlayerControls.Enable();
        Controls.controls.MenuControls.Disable();
        OnGame?.Invoke();
        transitionsManager.SetTrigger("PauseMenu-PlayerUI");
        Time.timeScale = 1f;
        }else{
            OnPause = true;
            transitionsManager.SetTrigger("Options-PauseMenu");
        }
    }
    public void ReloadGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_ReloadGame());
    }
    IEnumerator _ReloadGame(){
        transitionsManager.SetTrigger("DeathMenu-Loader");
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        transitionsManager.SetTrigger("Loader-PlayerUI");
        Restart?.Invoke();
        PlayerMovement.CanMove?.Invoke();
        Controls.controls.PlayerControls.Enable();
        Controls.controls.MainMenuControls.Disable();
        operation.allowSceneActivation = true;
        Time.timeScale = 1f;
    }
    public void GoMainMenu(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_GoMainMenu());
    }
    IEnumerator _GoMainMenu(){
        transitionsManager.SetTrigger("PauseMenu-Loader");
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        transitionsManager.SetTrigger("Loader-MainMenu");
        operation.allowSceneActivation = true;
        Controls.controls.MenuControls.Disable();
        Controls.controls.PlayerControls.Disable();
        Controls.controls.MainMenuControls.Enable(); 
        Time.timeScale = 1f;
    }
    public void DeathGoMainMenu(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_DeathGoMainMenu());
    }
    IEnumerator _DeathGoMainMenu(){
        transitionsManager.SetTrigger("DeathMenu-Loader");
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        transitionsManager.SetTrigger("Loader-MainMenu");
        Restart?.Invoke();
        PlayerMovement.CanMove?.Invoke();
        Controls.controls.MenuControls.Disable();
        Controls.controls.PlayerControls.Disable();
        Controls.controls.MainMenuControls.Enable(); 
        operation.allowSceneActivation = true;
        Time.timeScale = 1f;
    }
    void DeathMenu(){
        Debug.Log("Ap");
        Controls.controls.PlayerControls.Disable();
        StartCoroutine(_DeathMenu());
    }
    IEnumerator _DeathMenu(){
        yield return new WaitForSeconds(1.4f);
        Controls.controls.MainMenuControls.Enable();
        OnMenu?.Invoke();
        transitionsManager.SetTrigger("PlayerUI-DeathMenu");
        Time.timeScale = 0f;
    }
    public void OptionsMenu(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(SceneManager.GetActiveScene().buildIndex!=0){
            OnPause = false;
            transitionsManager.SetTrigger("PauseMenu-Options");
        }else{transitionsManager.SetTrigger("MainMenu-Options");}
    }
    public void HowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        transitionsManager.SetTrigger("MainMenu-HowToPlay");
    }
    public void Credits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        transitionsManager.SetTrigger("MainMenu-Credits");
    }
    public void ReturmFromOptions(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(SceneManager.GetActiveScene().buildIndex==0)
        transitionsManager.SetTrigger("Options-MainMenu");
        else{
            OnPause = true;
        transitionsManager.SetTrigger("Options-PauseMenu");
        }
    }
    public void ReturmFromCredits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        transitionsManager.SetTrigger("Credits-MainMenu");
    }
    public void ReturmFromHowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        transitionsManager.SetTrigger("HowToPlay-MainMenu");
    }

    public void QuitGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        	//If we are running in a standalone build of the game
        #if UNITY_STANDALONE
            Application.Quit();
        #endif

            //If we are running in the editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    public void LoadScene(int index){
        AudioManager.StopSteps?.Invoke();
        StartCoroutine(LoadAsynchronously(index));
    }
    IEnumerator LoadAsynchronously(int indexScene){
        if(indexScene==0){StartCoroutine(_GoMainMenu());}
        else{
            transitionsManager.SetTrigger("PlayerUI-Loader");
            AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[indexScene]);
            operation.allowSceneActivation = false;
            while(operation.progress<0.9f){
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                count.text = progress * 100f + "%";
                yield return null;
            }
            transitionsManager.SetTrigger("Loader-PlayerUI");
            operation.allowSceneActivation = true;
        }
    }
}
