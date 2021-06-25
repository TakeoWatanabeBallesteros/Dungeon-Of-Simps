using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
using System;
public enum UIPanel{
    BackgroundMain, BackgroundPause,
    MainMenu, PlayerUI,
    DeathMenu, PauseMenu,
    OptionsMenu, HowToPlay,
    Credits, LoadingScene
}
public class GameFlowControler : MonoBehaviour
{
    UIAnimation[] Panels;
    static GameFlowControler instance;
    bool OnPause = false;
    public TMP_Text count;
    List<string> levelNames;
    public Slider slider;
    public delegate void OnMenuDelegate();
    public static OnMenuDelegate OnMenu;
    public delegate void OnGameDelegate();
    public static OnGameDelegate OnGame;
    public delegate void RestartDelegate();
    public static RestartDelegate Restart;
    public Dictionary<UIPanel, UIAction> UIGroup;

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
            Panels = FindObjectsOfType<UIAnimation>();
            UIGroup = new Dictionary<UIPanel, UIAction>();
            foreach (UIAnimation a in Panels)
            {
                UIGroup.Add(a.uiPanel, new UIAction());
            }
            levelNames = new List<string>();
            levelNames.Add("MainMenu");
            levelNames.Add("Level 01");
            levelNames.Add("Level 02");
            levelNames.Add("Level 03");
        } else{
            Destroy(gameObject);
        }
    }
    void Start() {
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
        UIGroup[UIPanel.MainMenu].Disable(.2f);
        UIGroup[UIPanel.LoadingScene].Enable(.2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[1]);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.BackgroundMain].Disable(.2f);
        UIGroup[UIPanel.LoadingScene].Disable(.2f);
        UIGroup[UIPanel.PlayerUI].Enable(.2f);
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
        UIGroup[UIPanel.PlayerUI].Disable(.2f);
        UIGroup[UIPanel.BackgroundPause].Enable(.2f);
        UIGroup[UIPanel.PauseMenu].Enable(.2f);
        Time.timeScale = 0f;
    }
    public void ReturnGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(OnPause){
        Controls.controls.PlayerControls.Enable();
        Controls.controls.MenuControls.Disable();
        OnGame?.Invoke();
        UIGroup[UIPanel.PlayerUI].Enable(.2f);
        UIGroup[UIPanel.BackgroundPause].Disable(.2f);
        UIGroup[UIPanel.PauseMenu].Disable(.2f);
        Time.timeScale = 1f;
        }else{
            OnPause = true;
            UIGroup[UIPanel.PauseMenu].Enable(.2f);
            UIGroup[UIPanel.OptionsMenu].Disable(.2f);
        }
    }
    public void ReloadGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_ReloadGame());
    }
    IEnumerator _ReloadGame(){
        UIGroup[UIPanel.LoadingScene].Enable(.2f);
        UIGroup[UIPanel.BackgroundMain].Enable(.2f);
        UIGroup[UIPanel.DeathMenu].Disable(.2f);
        UIGroup[UIPanel.BackgroundPause].Disable(.2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(.2f);
        UIGroup[UIPanel.BackgroundMain].Disable(.2f);
        UIGroup[UIPanel.PlayerUI].Enable(.2f);
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
        UIGroup[UIPanel.LoadingScene].Enable(.2f);
        UIGroup[UIPanel.BackgroundMain].Enable(.2f);
        UIGroup[UIPanel.BackgroundPause].Disable(.2f);
        UIGroup[UIPanel.PauseMenu].Disable(.2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(.2f);
        UIGroup[UIPanel.MainMenu].Enable(.2f);
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
        UIGroup[UIPanel.DeathMenu].Disable(.2f);
        UIGroup[UIPanel.BackgroundPause].Disable(.2f);
        UIGroup[UIPanel.LoadingScene].Enable(.2f);
        UIGroup[UIPanel.BackgroundMain].Enable(.2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(.2f);
        UIGroup[UIPanel.MainMenu].Enable(.2f);
        Restart?.Invoke();
        PlayerMovement.CanMove?.Invoke();
        Controls.controls.MenuControls.Disable();
        Controls.controls.PlayerControls.Disable();
        Controls.controls.MainMenuControls.Enable(); 
        operation.allowSceneActivation = true;
        Time.timeScale = 1f;
    }
    void DeathMenu(){
        Controls.controls.PlayerControls.Disable();
        StartCoroutine(_DeathMenu());
    }
    IEnumerator _DeathMenu(){
        yield return new WaitForSeconds(1.4f);
        Controls.controls.MainMenuControls.Enable();
        OnMenu?.Invoke();
        UIGroup[UIPanel.DeathMenu].Enable(.2f);
        UIGroup[UIPanel.BackgroundPause].Enable(.2f);
        Time.timeScale = 0f;
    }
    public void OptionsMenu(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(SceneManager.GetActiveScene().buildIndex!=0){
            OnPause = false;
            UIGroup[UIPanel.PauseMenu].Disable(.2f);
            UIGroup[UIPanel.OptionsMenu].Enable(.2f);
        }else if(PlayerHealth.dead){
            UIGroup[UIPanel.OptionsMenu].Enable(.2f);
            UIGroup[UIPanel.DeathMenu].Disable(.2f);
        }else{
            UIGroup[UIPanel.OptionsMenu].Enable(.2f);
            UIGroup[UIPanel.MainMenu].Disable(.2f);
        }
    }
    public void HowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.HowToPlay].Enable(.2f);
        UIGroup[UIPanel.MainMenu].Disable(.2f);
    }
    public void Credits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.Credits].Enable(.2f);
        UIGroup[UIPanel.MainMenu].Disable(.2f);
    }
    public void ReturmFromOptions(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(SceneManager.GetActiveScene().buildIndex==0){
            UIGroup[UIPanel.OptionsMenu].Disable(.2f);
            UIGroup[UIPanel.MainMenu].Enable(.2f);
        }
        else if(PlayerHealth.dead){
            UIGroup[UIPanel.OptionsMenu].Disable(.2f);
            UIGroup[UIPanel.DeathMenu].Enable(.2f);
        }else{
            OnPause = true;
            UIGroup[UIPanel.PauseMenu].Enable(.2f);
            UIGroup[UIPanel.OptionsMenu].Disable(.2f);
        }
    }
    public void ReturmFromCredits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.Credits].Disable(.2f);
        UIGroup[UIPanel.MainMenu].Enable(.2f);
    }
    public void ReturmFromHowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.HowToPlay].Disable(.2f);
        UIGroup[UIPanel.MainMenu].Enable(.2f);
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
            UIGroup[UIPanel.LoadingScene].Enable(.2f);
            UIGroup[UIPanel.BackgroundMain].Enable(.2f);
            UIGroup[UIPanel.PlayerUI].Disable(.2f);
            AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[indexScene]);
            operation.allowSceneActivation = false;
            while(operation.progress<0.9f){
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                count.text = progress * 100f + "%";
                yield return null;
            }
            UIGroup[UIPanel.BackgroundMain].Disable(.2f);
            UIGroup[UIPanel.LoadingScene].Disable(.2f);
            UIGroup[UIPanel.PlayerUI].Enable(.2f);
            operation.allowSceneActivation = true;
        }
    }
}
