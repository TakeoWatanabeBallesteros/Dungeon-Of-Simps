using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageTaker
{
    public int ID;
    public float health;
    public float currentHealth => health;
    public GameObject trigger;
    public GameObject  coinPrefab;

    public delegate void OnHitDelegate();
    public OnHitDelegate OnHit;
    public delegate void OnDeathDelegate();
    public OnDeathDelegate OnDeath;
    bool dead = false;


    // Start is called before the first frame update
    void Start()
    {

    } 
    public void TakeDamage(float damage){
        health -= damage;
        if(health>0){
            switch (ID)
            {
                case 0:
                 EnemyAudioManager.Instance.PlayMiniMobEvent( 1, gameObject.transform.position);
                break;
                case 1:
                EnemyAudioManager.Instance.PlayWitchEvent( 1, gameObject.transform.position);
                break;
                case 2:
                EnemyAudioManager.Instance.PlayGolemEvent( 1, gameObject.transform.position);
                break;
                case 3:
                EnemyAudioManager.Instance.PlaySunEvent( 1, gameObject.transform.position);
                break;
            }
            OnHit?.Invoke();
        } else if(!dead){
            switch (ID)
            {
                case 0:
                 EnemyAudioManager.Instance.PlayMiniMobEvent( 2, gameObject.transform.position);
                break;
                case 1:
                EnemyAudioManager.Instance.PlayWitchEvent( 2, gameObject.transform.position);
                break;
                case 2:
                EnemyAudioManager.Instance.PlayGolemEvent( 2, gameObject.transform.position);
                break;
                case 3:
                EnemyAudioManager.Instance.PlaySunEvent( 2, gameObject.transform.position);
                break;
            }
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
            dead = true;
            Destroy(trigger);
            OnDeath?.Invoke();
        }
    }
}
