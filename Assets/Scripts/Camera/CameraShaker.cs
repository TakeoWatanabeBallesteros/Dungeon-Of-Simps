using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    private void OnEnable(){
        PlayerHealth.OnHit += HitShake;
        PlayerAbilities.OnDash += DashShake;
    }
    private void OnDisable(){
        PlayerHealth.OnHit -= HitShake;
        PlayerAbilities.OnDash -= DashShake;
    }
    public IEnumerator Shake(float duration, float magnitude){
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration){
            float x = Random.Range(-1f, 1f)*magnitude;
            float y = Random.Range(-1f, 1f)*magnitude;
            transform.localPosition = new Vector3(x+transform.localPosition.x, y+transform.localPosition.y, -10);
            elapsed += Time.deltaTime;
            yield return null;
        }
        //transform.localPosition = originalPos;
    }
    private void HitShake(){
        StartCoroutine(Shake(.1f, .07f));
    }
    private void DashShake(){
        StartCoroutine(Shake(.2f, .1f));
    }
}
