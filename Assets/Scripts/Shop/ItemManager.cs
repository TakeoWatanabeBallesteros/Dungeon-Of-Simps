using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]
    int index;
    [SerializeField]
    public int cost;
    ShopManager shopManager;
    private void Start() {
       shopManager = GetComponentInParent<Transform>().parent.GetComponentInParent<ShopManager>();
    }
    public void OnClick(){
        if(shopManager.itemsImage[index]!=null)
        {
            shopManager.itemsDescription[shopManager.indexItem].SetActive(false);
            shopManager.itemsImage[shopManager.indexItem].SetActive(false);
            shopManager.itemsDescription[index].SetActive(true);
            shopManager.itemsImage[index].SetActive(true);
            shopManager.indexItem = index;
        }
        UIAudioManager.Instance.PlayUIClickEvent();
    }
}
