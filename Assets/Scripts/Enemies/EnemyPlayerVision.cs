using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerVision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        CameraPlayer.normal = false;
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player"))
        CameraPlayer.normal = true;
    }
    private void OnDestroy() {
        CameraPlayer.normal = true;
    }
}