using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int indexItem;
    [SerializeField]
    List<GameObject> items;
    [SerializeField]
    public List<GameObject> itemsImage;
    [SerializeField]
    public List<GameObject> itemsDescription;
    ItemManager itemManager;
    public void Buy(){
        UIAudioManager.Instance.PlayUIClickEvent();
        itemManager = items[indexItem].GetComponent<ItemManager>();
        if(PlayerCoinsManager.coins >= itemManager.cost){
            switch (indexItem)
            {
                case 0:
                    PlayerHealth.healthPotions++;
                    PlayerHealth.BoughtPotion?.Invoke();
                break;
                case 1:
                    AudioManager.Instance.PlayPowerupEvent(transform.position);
                    if(BulletSpawner.TypeAttack.Count==2)
                    BulletSpawner.TypeAttack.Add(2);
                    if(BulletSpawner.TypeAttack.Count==1)
                    BulletSpawner.TypeAttack.Add(1);
                break;
                case 2:
                    PlayerHealth.LifePowerUp?.Invoke();
                break;
                case 3:
                    
                break;
                case 4:

                break;
                case 5:

                break;
                case 6:

                break;
                case 7:

                break;
                case 8:

                break;
                case 9:

                break;
                case 10:

                break;
                case 11:

                break;
            }
            PlayerCoinsManager.coins -= itemManager.cost;
            PlayerCoinsManager.MoreCoins?.Invoke();
        }
    }
}
