using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public static _Controls controls;
    private void Awake() {
        if(controls == null){
            controls = new _Controls();
            DontDestroyOnLoad(gameObject);
        } else{
            Destroy(gameObject);
        }
    }
}
