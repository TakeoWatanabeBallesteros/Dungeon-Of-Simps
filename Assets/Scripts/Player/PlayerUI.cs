using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TMP_Text dashCount, SlowmoCount;
    PlayerAbilities playerAbilities;
    PlayerHealth playerHealth;
    public Image[] hearts;
    public TMP_Text defaultShoot, tripleShoot, circleShoot;
    public Sprite fullHearts, halfHearts, emptyHearts;
    private void OnEnable() {
        PlayerHealth.OnHit += FitNumOfHearts;
        PlayerHealth.LifePowerUp += FitNumOfHearts;
        BulletSpawner.GunType += TypeOfShoot;
        PlayerHealth.CheckHealth += FitNumOfHearts;
    }
    private void OnDisable(){
        PlayerHealth.OnHit -= FitNumOfHearts;
        PlayerHealth.LifePowerUp -= FitNumOfHearts;
        BulletSpawner.GunType -= TypeOfShoot;
        PlayerHealth.CheckHealth -= FitNumOfHearts;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerAbilities = GetComponent<PlayerAbilities>();
        playerHealth = GetComponent<PlayerHealth>();
        FitNumOfHearts();
    }

    // Update is called once per frame
    void Update()
    {
        AbilitiesCooldown();
    }
    void AbilitiesCooldown(){
        if(playerAbilities.dashCoolDown>=0)
        dashCount.text = ""+Mathf.Round(playerAbilities.dashCoolDown);
        if(playerAbilities.slowMoCoolDown >=0)
        SlowmoCount.text = ""+Mathf.Round(playerAbilities.slowMoCoolDown);
    }
    void FitNumOfHearts(){
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i+.5<playerHealth.currentHealth) hearts[i].sprite = fullHearts;
            else if(i+.5>=playerHealth.currentHealth&&i<playerHealth.currentHealth) hearts[i].sprite = halfHearts;
            else hearts[i].sprite = emptyHearts;
            if(i<playerHealth.currentTotalHealth) hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }
    void TypeOfShoot(){
        switch (BulletSpawner.TypeAttack[BulletSpawner.indx])
        {
            case 0:
                defaultShoot.enabled = true;
                tripleShoot.enabled = false;
                circleShoot.enabled = false;
                break;
            case 1:
                defaultShoot.enabled = false;
                tripleShoot.enabled = true;
                circleShoot.enabled = false;
                break;
            case 2:
                defaultShoot.enabled = false;
                tripleShoot.enabled = false;
                circleShoot.enabled = true;
                break;
            default:
                break;
        }
    }
}
