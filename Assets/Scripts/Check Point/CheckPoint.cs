using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class CheckPoint : MonoBehaviour
{
    static CheckPoint checkPoint;
    CheckPoint _checkPoint;
    Transform player;
    StudioEventEmitter checkPointSound;
    public GameObject fireLight;
    [SerializeField]
    private GameObject sparks;
    private float maxDistance = 1f;

    void Awake(){
        if(checkPoint != null){
            Destroy(gameObject);
        }else{
            checkPoint = this;
            DontDestroyOnLoad(gameObject);
        }
        checkPointSound = GetComponent<StudioEventEmitter>();
    }
    private void Start() {
        player = PlayerSingleton.Instance.GetComponent<Transform>();
        checkPointSound = GetComponent<StudioEventEmitter>();
    }
    public void CheckPoint_(){
        float distance = Vector2.Distance(player.position, transform.position);
        if(distance <= maxDistance&&!fireLight.activeSelf){
            checkPointSound.Play();
            sparks.SetActive(true);
            gameObject.GetComponent<Animator>().SetBool("On", true);
            fireLight.SetActive(true);
        }
    }
    public void TurnOff(){
        checkPointSound.Stop();
        sparks.SetActive(false);
        gameObject.GetComponent<Animator>().SetBool("On", false);
    }
}
