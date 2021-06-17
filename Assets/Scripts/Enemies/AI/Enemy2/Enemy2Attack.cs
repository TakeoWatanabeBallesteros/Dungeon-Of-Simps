using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Attack : MonoBehaviour
{
    AttackState attackState;
    public GameObject bulletPrefab;
    Transform player;
    float speed = 10;
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
    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot(){
        StartCoroutine(_Shoot());
    }
    IEnumerator _Shoot(){
        float startAngle = -10;
        int lines = 3;
        float angleStep = 10;
        EnemyAudioManager.Instance.PlayWitchEvent( 0, gameObject.transform.position);
        for (int y = 0; y < 3; y++)
        {
            float angle = startAngle;
            for (int i = 0; i < lines; i++)
            {
                GameObject bulletClones = Instantiate(bulletPrefab);
                bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
                var direction = (Quaternion.Euler(0, 0, angle)*(player.position - transform.position)).normalized;
                bulletClones.transform.rotation = transform.rotation;
                bulletClones.GetComponent<Rigidbody2D>().velocity = direction*speed;
                angle += angleStep;
            }
            yield return new WaitForSeconds(0.1f);
        } 
    }
}
