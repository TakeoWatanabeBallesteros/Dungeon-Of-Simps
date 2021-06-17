using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISingletone : MonoBehaviour
{
    public static GameObject Instance {get; private set; }
    private void Awake() {
        if(Instance == null){
            Instance = gameObject;
            DontDestroyOnLoad(Instance);
        } else{
            Destroy(gameObject);
        }
    }
}
