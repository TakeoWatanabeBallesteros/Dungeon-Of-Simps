using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.CompareTag("Player")){
           PlayerCoinsManager.coins++;
           PlayerCoinsManager.MoreCoins?.Invoke();
           Destroy(gameObject);
       }
   }
}
