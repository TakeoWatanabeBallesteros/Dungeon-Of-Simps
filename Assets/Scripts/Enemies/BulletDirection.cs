using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    GameObject player;
    float speed;
    bool followEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if(followEnemy){
            Vector2 direction = new Vector2(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y).normalized;
            gameObject.GetComponent<Rigidbody2D>().velocity = direction*gameObject.GetComponent<Rigidbody2D>().velocity;
        }
    }
}
