using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BidonDestroy : MonoBehaviour, IDamageTaker
{
    public GameObject particles;
    byte health;

    void Start()
    {
        health = 3;
    }
    public void TakeDamage(float damage){
        if(health >1){AudioManager.Instance.PlayWoodHitEvent(transform.position);}
             health--;
            if(health == 0){
                AudioManager.Instance.PlayWoodDestroyEvent(transform.position);
                Instantiate(particles, transform.position, new Quaternion(-.7f, 0, 0, .7f));
                Destroy(gameObject);
            }
    }
}
