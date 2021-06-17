using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            AudioManager.Instance.PlayPowerupEvent(transform.position);
            if(BulletSpawner.TypeAttack.Count==2)
            BulletSpawner.TypeAttack.Add(2);
            if(BulletSpawner.TypeAttack.Count==1)
            BulletSpawner.TypeAttack.Add(1);
            Destroy(gameObject);
        }
    }
}
