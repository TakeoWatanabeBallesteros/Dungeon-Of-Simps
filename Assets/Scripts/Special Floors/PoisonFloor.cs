using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonFloor : MonoBehaviour
{
    PlayerHealth playerHealth;
    bool inPoison;
    float timePoisonEffect;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = PlayerSingleton.Instance.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inPoison)
            timePoisonEffect = 0;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("PlayerColision")){
            inPoison=true;
            timePoisonEffect = 0;
            StartCoroutine(PoisonHit());
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("PlayerColision")){
            inPoison=false;
        }
    }
    IEnumerator PoisonHit(){
        while (timePoisonEffect<10&&playerHealth.currentHealth>0)
        {
            playerHealth.TakeDamage(.15f);
            timePoisonEffect +=1;
            yield return new WaitForSeconds(1.6f);
        }
    }
}
