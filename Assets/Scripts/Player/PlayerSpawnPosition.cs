using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPosition : MonoBehaviour
{
    GameObject mainCamera;
    private void Start() {
        PlayerSingleton.Instance.GetComponent<Transform>().position = transform.position;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        mainCamera.transform.position = transform.position;
    }
}
