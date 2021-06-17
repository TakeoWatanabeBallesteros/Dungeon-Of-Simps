using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFloor : MonoBehaviour
{
    //public Rigidbody2D rbPlayer;
    public static bool onIce;
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("PlayerColision")){
            onIce = true;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("PlayerColision")&&onIce){
            onIce = false;
        }
    }
}
