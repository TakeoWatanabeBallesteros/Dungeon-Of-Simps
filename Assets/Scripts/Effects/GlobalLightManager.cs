using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GlobalLightManager : MonoBehaviour
{
    Light2D Light;
    GameObject player;
    bool done = false;
    private void OnEnable() {
        PlayerHealth.LowHealth += _LowHealth;
        PlayerHealth.LifePowerUp += NormalHealth;
    }
    private void OnDisable(){
        PlayerHealth.LowHealth -= _LowHealth;
        PlayerHealth.LifePowerUp -= NormalHealth;
    }
    void Start()
    {
        player = PlayerSingleton.Instance;
        Light = gameObject.GetComponent<Light2D>();
    }

    void Update()
    {
    }
    void _LowHealth(){
        if(!done){
        StartCoroutine(LowHealth());
        done = true;
        }
    }
    IEnumerator LowHealth(){
        while(player.GetComponent<PlayerHealth>().currentHealth<2){
            Light.intensity = UnityEngine.Random.Range(0.2f, 0.4f);
            yield return new WaitForSeconds(.3f);
        }
    }
    void NormalHealth(){
        if(player.GetComponent<PlayerHealth>().currentHealth>=1)
            Light.intensity = 0.5f;
    }
}
