using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroyer : MonoBehaviour
{
    public GameObject particles;
    private void Start() {
        Destroy(gameObject, 3);
    }
    PlayerHealth playerHealth;
    private void OnCollisionEnter2D(Collision2D other){
        if(!other.gameObject.CompareTag("PlayerColision")){
            Instantiate(particles, transform.position, new Quaternion(-.7f, 0, 0, 0));
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            playerHealth = other.GetComponent<PlayerHealth>();
            if(!playerHealth.inmune){
            playerHealth.TakeDamage(0.25f);
            playerHealth.Punch(gameObject);
            Instantiate(particles, transform.position, new Quaternion(-.7f, 0, 0, 0));
            Destroy(gameObject);
            }
        }
    }
}
