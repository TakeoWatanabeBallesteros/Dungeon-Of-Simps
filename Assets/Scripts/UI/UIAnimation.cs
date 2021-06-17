using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    CanvasGroup canvasGroup;
    private void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void Enable(float seconds){
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        StartCoroutine(Appear(seconds));
    }
    IEnumerator Appear(float seconds){
        while(canvasGroup.alpha < 1){
            canvasGroup.alpha += 0.4f;
            yield return new WaitForSecondsRealtime(seconds);
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
