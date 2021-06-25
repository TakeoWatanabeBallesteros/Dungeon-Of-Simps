using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIAction{
    public Action<float> Enable;
    public Action<float> Disable;
}

public class UIAnimation : MonoBehaviour
{
    public UIPanel uiPanel;
    GameFlowControler gameFlowControler;
    private void Awake() {
        gameFlowControler = FindObjectOfType<GameFlowControler>();
    }
    private void Start() {
        gameFlowControler.UIGroup[uiPanel].Enable = (t) => Enable(t);
        gameFlowControler.UIGroup[uiPanel].Disable = (t) => Disable(t);
    }
    public void Enable(float seconds){
        var canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        StartCoroutine(Appear(canvasGroup, seconds));
    }
    IEnumerator Appear(CanvasGroup canvasGroup ,float seconds){
        float t=0;
        while(t<seconds){
            t+=Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(0,1,t/seconds);
            yield return null;
        }
    }
    public void Disable(float seconds){
        var canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        StartCoroutine(Disappear(canvasGroup, seconds));
    }
    IEnumerator Disappear(CanvasGroup canvasGroup, float seconds){
        float t=0;
        while(t<seconds){
            t+=Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(1,0,t/seconds);
            yield return null;
        }
    }
}
