using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    float timer;
    public GameObject coinContainerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }
    void Spawner(){
        timer+=Time.deltaTime;
        if (timer>3)
        {
            Vector3 spawn = new Vector3(Random.Range(-5.0f,5.95f), Random.Range(4.0f,-4.37f), 0);
            timer=0;
            Instantiate(coinContainerPrefab, spawn,Quaternion.identity);
        }
    }
}
