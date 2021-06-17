using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            AudioManager.Instance.PlayPowerupEvent(transform.position);
            PlayerHealth.LifePowerUp?.Invoke();
            Destroy(gameObject);
        }
    }
}
