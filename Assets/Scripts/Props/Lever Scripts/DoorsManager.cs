using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsManager : MonoBehaviour
{
    static DoorsManager doorsManager;
    private void Awake() {
        if(doorsManager == null){
            doorsManager = this;
            DontDestroyOnLoad(gameObject);
        } else{
            Destroy(gameObject);
        }
    }
}
