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
    CanvasGroup canvasGroup;
    [SerializeField]
    UIPanel uiPanel;
    private void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    private void Start() {
        GameFlowControler.UIGroup[uiPanel].Enable = (t) => Enable(t);
        GameFlowControler.UIGroup[uiPanel].Disable = (t) => Disable(t);
    }
    public void Enable(float seconds){
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        StartCoroutine(Appear(seconds));
    }
    IEnumerator Appear(float seconds){
        float t=0;
        while(t<seconds){
            t+=Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(0,1,t/seconds);
            yield return null;
        }
    }
    public void Disable(float seconds){
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        StartCoroutine(Disappear(seconds));
    }
    IEnumerator Disappear(float seconds){
        float t=0;
        while(t<seconds){
            t+=Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(1,0,t/seconds);
            yield return null;
        }
    }
}
