using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int indexScene;
    GameFlowControler gameFlowControler;
    private void Start() {
        gameFlowControler = GameObject.FindGameObjectWithTag("UI").GetComponent<GameFlowControler>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){ gameFlowControler.LoadScene(indexScene); }
    }
    
}
