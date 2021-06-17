using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Attack : MonoBehaviour
{
    AttackState attackState;
    public GameObject bulletPrefab;
    Transform player;
    float speed = 8;
    private void Awake() {
        attackState = transform.parent.GetComponent<AttackState>();
    }
    private void Start() {
        player = PlayerSingleton.Instance.GetComponent<Transform>();
    }
    private void OnEnable() {
        attackState.OnAttack += Shoot;
    }
    private void OnDisable() {
        attackState.OnAttack -= Shoot;
    }
    void Shoot(){
        EnemyAudioManager.Instance.PlayMiniMobEvent( 0, gameObject.transform.position);
        GameObject bulletClones = Instantiate(bulletPrefab);
        bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
        var direction = (player.position - transform.position).normalized;
        bulletClones.transform.rotation = transform.rotation;
        bulletClones.GetComponent<Rigidbody2D>().velocity = direction*speed;
    }
}
