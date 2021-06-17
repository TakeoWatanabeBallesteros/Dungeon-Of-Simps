using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTrigger : MonoBehaviour
{
    AttackState attackState;
    public GameObject bulletPrefab;
    EnemyHealth enemyHealth;
    public float startAngle, endAngle, lines, repeatTime, speed;
    float _startAngle, _endAngle;
    public bool rotation;
    private void OnEnable() {
        attackState.OnAttack += Attack;
    }
    private void OnDisable() {
        attackState.OnAttack -= Attack;
    }
    private void Awake() {
        attackState = transform.parent.GetComponent<AttackState>();
    }
    void Start()
    {
        enemyHealth = transform.parent.GetComponent<EnemyHealth>();
        _startAngle = startAngle;
        _endAngle = endAngle;
        
    }
    void Attack(){
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        while(true){
            if(enemyHealth.currentHealth <= 7){
                rotation = true;
                lines = 8;
                repeatTime = 0.25f;
            }
            if(rotation){
                startAngle+=15; 
                endAngle+=15;
                if(startAngle == Mathf.Abs(_endAngle)){
                    startAngle = _startAngle;
                    endAngle = _endAngle;
                }
            }
            /*float angleStep = (endAngle - startAngle)/lines;
            float angle = startAngle;
            for (int i = 0; i < lines; i++)
            {
                GameObject bulletClones = Instantiate(bulletPrefab);
                bulletClones.transform.position =  new Vector3(transform.position.x, transform.position.y, 1);
                var direction = Quaternion.Euler(0, 0, angle)*transform.right;
                bulletClones.transform.rotation = transform.rotation;
                bulletClones.GetComponent<Rigidbody2D>().velocity = direction*speed;

                angle += angleStep;
            }*/
            EnemyAudioManager.Instance.PlaySunEvent( 0, gameObject.transform.position);
            float angleStep = (endAngle - startAngle)/lines;
            float angle = startAngle;
            for (int i = 0; i < lines+1; i++)
            {
                float bulletDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI)/180f);
                float bulletDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI)/180f);
                Vector3 bulletDirection = new Vector3(bulletDirX, bulletDirY, 0f);
                Vector2 bulletVectorUnit = (bulletDirection - transform.position).normalized;
                GameObject bulletClones = Instantiate(bulletPrefab);
                bulletClones.transform.position = transform.position;
                bulletClones.transform.rotation = transform.rotation;
                bulletClones.GetComponent<Rigidbody2D>().velocity = bulletVectorUnit * speed;

                angle += angleStep;
            }
            yield return new WaitForSeconds(repeatTime);
        }
    }
}
