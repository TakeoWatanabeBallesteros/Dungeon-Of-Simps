using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFloor : MonoBehaviour
{   
    PlayerHealth playerHealth;
    bool inLava;
    private void Start() {
        playerHealth = PlayerSingleton.Instance.GetComponent<PlayerHealth>();
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("PlayerColision")){
            inLava=true;
            StartCoroutine(LavaHit());
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("PlayerColision")){
            inLava=false;
        }
    }
    IEnumerator LavaHit(){
        while (inLava&&playerHealth.currentHealth>0)
        {
            playerHealth.TakeDamage(0.25f);
            yield return new WaitForSeconds(.85f);
        }
    }
}
