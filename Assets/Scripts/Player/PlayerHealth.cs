using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour, IDamageTaker
{
    Rigidbody2D rb;
    float punchDistance=5f;
    public float health;
    private float totalHealth = 5;
    public float currentTotalHealth => totalHealth;
    public float currentHealth => health;
    public bool inmune = false;
    public static bool dead;
    public static int healthPotions;
    
    public delegate void OnHitDelegate();
    public static OnHitDelegate OnHit;
    public delegate void OnDeathDelegate();
    public static OnDeathDelegate OnDeath;
    public delegate void LifePowerUpDelegate();
    public static LifePowerUpDelegate LifePowerUp;
    public delegate void LowHealthDelegate();
    public static LowHealthDelegate LowHealth;
    public delegate void CheckHealthDelegate();
    public static CheckHealthDelegate CheckHealth;
    public delegate void BoughtPotionDelegate();
    public static BoughtPotionDelegate BoughtPotion;
    public delegate void UsePotionDelegate();
    public static UsePotionDelegate UsePotion;

    void OnEnable() {
        PlayerAbilities.OnDash += _Inmune;
        GameFlowControler.Restart += ResetHealth;
        LifePowerUp += MoreHealth;
    }
    void OnDisable() {
        PlayerAbilities.OnDash -= _Inmune;
        GameFlowControler.Restart -= ResetHealth;
        LifePowerUp -= MoreHealth;
    }
    void Awake() {
        health = totalHealth;
    }
    void Start()
    {
        Controls.controls.PlayerControls.Health.started +=_=>Healthing();
        rb = GetComponent<Rigidbody2D>();
        dead = false;
    }
    void Update(){
    }
    public void TakeDamage(float damage){
        if(!inmune){
            health-=damage;
            if(health>0.01f){
                Hit();
                if(health<2){
                    LowHealth?.Invoke();
                }
            } else if(!dead) {
                dead = true;
                Death(); 
            }
        }
    }
    public IEnumerator HitPunch(GameObject bullet){
        Vector2 bulletPos = bullet.transform.position;
        Vector2 direction = new Vector2(transform.position.x - bulletPos.x, transform.position.y - bulletPos.y).normalized;
        PlayerMovement.CantMove?.Invoke();
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(direction.x*punchDistance, direction.y*punchDistance),ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.1f);
        PlayerMovement.CanMove?.Invoke();
        Destroy(bullet);
    }
    public IEnumerator Inmune(float inmuneTime){
        inmune = true;
        yield return new WaitForSeconds(inmuneTime);
        inmune = false;
    }
    void Hit(){
        AudioManager.Instance.PlayGirlHitEvent();
        OnHit?.Invoke();
        StartCoroutine(Inmune(.3f));
    }
    public void Punch(GameObject bullet){
        StartCoroutine(HitPunch(bullet));
    }
    void Death(){
        rb.velocity = Vector2.zero;
        PlayerMovement.CantMove?.Invoke();
        OnDeath?.Invoke();
    }
    void _Inmune(){
        StartCoroutine(Inmune(.4f));
    }
    void MoreHealth(){
        if(health<9&&totalHealth<10){
            totalHealth++;
            health++;
        }
        CheckHealth?.Invoke();
    }
    void Healthing(){
        if(healthPotions>0){
            healthPotions--;
            if(health<totalHealth-1){
                health++;
            }else{
                health = totalHealth;
            }
            AudioManager.Instance.PlayPowerupEvent(transform.position);
            CheckHealth?.Invoke();
        }
        UsePotion?.Invoke();
    }
    void ResetHealth(){
        dead = false;
        totalHealth = 5;
        health = 5;
        CheckHealth?.Invoke();
    }
}
