using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy2Pathfinder : MonoBehaviour
{
    GameObject player;
    float speed = 2.7f;
    float nextWaypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    Rigidbody2D rb;
    public float stopDistance, retreatDistance;
    AttackState attackState;
    Seeker seeker;
    // Start is called before the first frame update
    private void OnEnable() {
        attackState.OnMove += FollowPlayer;
    }
    private void OnDisable() {
        attackState.OnMove -= FollowPlayer;
    }
    void Awake()
    {
        attackState = GetComponent<Enemy2AttackState>();
    }
    private void Start() {
        player = PlayerSingleton.Instance;
        rb = GetComponent<Rigidbody2D>();
        seeker = GetComponent<Seeker>();
        InvokeRepeating("UpdatePath", 0f, .5f);
    }
    void UpdatePath(){
        if(seeker.IsDone()){
            seeker.StartPath(rb.position, player.transform.position, OnPathComplete);
        }
    }
    void OnPathComplete(Path p){
        if(!p.error){
            path = p;
            currentWaypoint = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FollowPlayer(){
        if(path==null)
            return;
        if(currentWaypoint >= path.vectorPath.Count){
            return;
        }
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint]-rb.position).normalized;
        float distance = Vector2.Distance(transform.position, player.transform.position);
        float _distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
        if(_distance<nextWaypointDistance){
            currentWaypoint++;
        }
        if(distance>stopDistance){
            rb.velocity = new Vector2(direction.x*speed, direction.y*speed);
        }else if(distance < stopDistance && distance < retreatDistance){
            rb.velocity = new Vector2(-direction.x*speed, -direction.y*speed);
        }else if(distance<stopDistance&&distance>retreatDistance){
            rb.velocity = Vector2.zero;
        }
    }
}
