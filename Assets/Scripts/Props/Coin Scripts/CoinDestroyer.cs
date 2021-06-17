using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PointsManager.pointsManager.PointsUpdate(1);
        Destroy(transform.parent.gameObject);
    }
}
