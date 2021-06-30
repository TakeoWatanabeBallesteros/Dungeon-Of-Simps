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
    Credits, LoadingScene,
    Shop
}
public class GameFlowControler : MonoBehaviour
{
    UIAnimation[] Panels;
    static GameFlowControler instance;
    bool OnPause = false;
    bool OnShop = false;
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
    float transitionTime = .2f;

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
        OnShop = true;
        UIGroup[UIPanel.MainMenu].Disable(transitionTime);
        UIGroup[UIPanel.LoadingScene].Enable(transitionTime);
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[1]);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        Time.timeScale = 0;
        UIGroup[UIPanel.BackgroundMain].Disable(transitionTime);
        UIGroup[UIPanel.LoadingScene].Disable(transitionTime);
        UIGroup[UIPanel.Shop].Enable(transitionTime);
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
        UIGroup[UIPanel.PlayerUI].Disable(transitionTime);
        UIGroup[UIPanel.BackgroundPause].Enable(transitionTime);
        UIGroup[UIPanel.PauseMenu].Enable(transitionTime);
        Time.timeScale = 0f;
    }
    public void ReturnGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(OnPause){
            OnPause = false;
            Controls.controls.PlayerControls.Enable();
            Controls.controls.MenuControls.Disable();
            OnGame?.Invoke();
            UIGroup[UIPanel.PlayerUI].Enable(transitionTime);
            UIGroup[UIPanel.BackgroundPause].Disable(transitionTime);
            UIGroup[UIPanel.PauseMenu].Disable(transitionTime);
            Time.timeScale = 1f;
        }else if(OnShop){
            OnShop = false;
            Controls.controls.PlayerControls.Enable();
            Controls.controls.MenuControls.Disable();
            OnGame?.Invoke();
            UIGroup[UIPanel.PlayerUI].Enable(transitionTime);
            UIGroup[UIPanel.Shop].Disable(transitionTime);
            Time.timeScale = 1f;
        }else{
            OnPause = true;
            UIGroup[UIPanel.PauseMenu].Enable(transitionTime);
            UIGroup[UIPanel.OptionsMenu].Disable(transitionTime);
        }
    }
    public void ReloadGame(){
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_ReloadGame());
    }
    IEnumerator _ReloadGame(){
        UIGroup[UIPanel.LoadingScene].Enable(transitionTime);
        UIGroup[UIPanel.BackgroundMain].Enable(transitionTime);
        UIGroup[UIPanel.DeathMenu].Disable(transitionTime);
        UIGroup[UIPanel.BackgroundPause].Disable(transitionTime);
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(transitionTime);
        UIGroup[UIPanel.BackgroundMain].Disable(transitionTime);
        UIGroup[UIPanel.PlayerUI].Enable(transitionTime);
        Restart?.Invoke();
        PlayerMovement.CanMove?.Invoke();
        Controls.controls.PlayerControls.Enable();
        Controls.controls.MainMenuControls.Disable();
        operation.allowSceneActivation = true;
        Time.timeScale = 1f;
    }
    public void GoMainMenu(){
        OnPause = false;
        UIAudioManager.Instance.PlayUIClickEvent();
        StartCoroutine(_GoMainMenu());
    }
    IEnumerator _GoMainMenu(){
        UIGroup[UIPanel.LoadingScene].Enable(transitionTime);
        UIGroup[UIPanel.BackgroundMain].Enable(transitionTime);
        UIGroup[UIPanel.BackgroundPause].Disable(transitionTime);
        UIGroup[UIPanel.PauseMenu].Disable(transitionTime);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(transitionTime);
        UIGroup[UIPanel.MainMenu].Enable(transitionTime);
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
        UIGroup[UIPanel.DeathMenu].Disable(transitionTime);
        UIGroup[UIPanel.BackgroundPause].Disable(transitionTime);
        UIGroup[UIPanel.LoadingScene].Enable(transitionTime);
        UIGroup[UIPanel.BackgroundMain].Enable(transitionTime);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;
        while(operation.progress<0.9f){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            count.text = progress * 100f + "%";
            yield return null;
        }
        UIGroup[UIPanel.LoadingScene].Disable(transitionTime);
        UIGroup[UIPanel.MainMenu].Enable(transitionTime);
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
        AudioManager.StopSteps?.Invoke();
        yield return new WaitForSeconds(1.4f);
        Controls.controls.MainMenuControls.Enable();
        OnMenu?.Invoke();
        UIGroup[UIPanel.PlayerUI].Disable(transitionTime);
        UIGroup[UIPanel.DeathMenu].Enable(transitionTime);
        UIGroup[UIPanel.BackgroundPause].Enable(transitionTime);
        Time.timeScale = 0f;
    }
    public void OptionsMenu(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(PlayerHealth.dead){
            UIGroup[UIPanel.OptionsMenu].Enable(transitionTime);
            UIGroup[UIPanel.DeathMenu].Disable(transitionTime);
        }else if(SceneManager.GetActiveScene().buildIndex!=0){
            OnPause = false;
            UIGroup[UIPanel.PauseMenu].Disable(transitionTime);
            UIGroup[UIPanel.OptionsMenu].Enable(transitionTime);
        }else{
            UIGroup[UIPanel.OptionsMenu].Enable(transitionTime);
            UIGroup[UIPanel.MainMenu].Disable(transitionTime);
        }
    }
    public void HowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.HowToPlay].Enable(transitionTime);
        UIGroup[UIPanel.MainMenu].Disable(transitionTime);
    }
    public void Credits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.Credits].Enable(transitionTime);
        UIGroup[UIPanel.MainMenu].Disable(transitionTime);
    }
    public void ReturmFromOptions(){
        UIAudioManager.Instance.PlayUIClickEvent();
        if(SceneManager.GetActiveScene().buildIndex==0){
            UIGroup[UIPanel.OptionsMenu].Disable(transitionTime);
            UIGroup[UIPanel.MainMenu].Enable(transitionTime);
        }
        else if(PlayerHealth.dead){
            UIGroup[UIPanel.OptionsMenu].Disable(transitionTime);
            UIGroup[UIPanel.DeathMenu].Enable(transitionTime);
        }else{
            OnPause = true;
            UIGroup[UIPanel.PauseMenu].Enable(transitionTime);
            UIGroup[UIPanel.OptionsMenu].Disable(transitionTime);
        }
    }
    public void ReturmFromCredits(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.Credits].Disable(transitionTime);
        UIGroup[UIPanel.MainMenu].Enable(transitionTime);
    }
    public void ReturmFromHowToPlay(){
        UIAudioManager.Instance.PlayUIClickEvent();
        UIGroup[UIPanel.HowToPlay].Disable(transitionTime);
        UIGroup[UIPanel.MainMenu].Enable(transitionTime);
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
            UIGroup[UIPanel.LoadingScene].Enable(transitionTime);
            UIGroup[UIPanel.BackgroundMain].Enable(transitionTime);
            UIGroup[UIPanel.PlayerUI].Disable(transitionTime);
            AsyncOperation operation = SceneManager.LoadSceneAsync(levelNames[indexScene]);
            operation.allowSceneActivation = false;
            while(operation.progress<0.9f){
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                count.text = progress * 100f + "%";
                yield return null;
            }
            UIGroup[UIPanel.BackgroundMain].Disable(transitionTime);
            UIGroup[UIPanel.LoadingScene].Disable(transitionTime);
            UIGroup[UIPanel.PlayerUI].Enable(transitionTime);
            operation.allowSceneActivation = true;
        }
    }
}
