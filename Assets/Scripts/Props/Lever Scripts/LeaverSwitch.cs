using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeaverSwitch : MonoBehaviour
{
    GameObject doorClose, doorOpen, player;

    private float maxDistance = 1.3f;
    public bool Open = false;
    private void Start() {
        player = PlayerSingleton.Instance;
        doorClose = transform.parent.gameObject.transform.GetChild(0).gameObject;
        doorOpen = transform.parent.gameObject.transform.GetChild(1).gameObject;
    }
    public void OpenTheDoor() {
        float distance = Vector2.Distance(player.GetComponent<Transform>().position, transform.position);
        //Debug.Log(distance);
        if(distance <= maxDistance){
            if(!Open){
            gameObject.GetComponent<Animator>().SetBool("Switch", true);
            doorClose.SetActive(false);
            doorOpen.SetActive(true);
            Open = true;
            AudioManager.Instance.PlayDoorEvent(gameObject, 0);
            }
            else if(Open){
            gameObject.GetComponent<Animator>().SetBool("Switch", false);
            doorClose.SetActive(true);
            doorOpen.SetActive(false);
            Open = false;
            AudioManager.Instance.PlayDoorEvent(gameObject, 1);
            }
        }
    }
    public void CloseDoor(){
        gameObject.GetComponent<Animator>().SetBool("Switch", false);
        doorClose.SetActive(true);
        doorOpen.SetActive(false);
        Open = false;
    }
}
