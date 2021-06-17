using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    EnemyHealth enemyHealth;
    AttackState attackState;
    PatrolAI patrolAI;
    private void Awake() {
        animator = GetComponent<Animator>();
        enemyHealth = transform.parent.GetComponent<EnemyHealth>();
        attackState = transform.parent.GetComponent<AttackState>();
        patrolAI = transform.parent.GetComponent<PatrolAI>();
        rb = transform.parent.GetComponent<Rigidbody2D>();
    }
    private void OnEnable() {
        enemyHealth.OnHit += HitAnimation;
        enemyHealth.OnDeath += DeathAnimation;
        attackState.OnAttack += AttackAnimation;
    }
    private void OnDisable() {
        enemyHealth.OnHit -= HitAnimation;
        enemyHealth.OnDeath -= DeathAnimation;
        attackState.OnAttack -= AttackAnimation;
    }
    private void Update() {
        MovingAnimation();
        if(transform.position.x-PlayerSingleton.Instance.transform.position.x>0){
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }else{
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    void MovingAnimation(){
       if(rb.velocity != Vector2.zero){
           animator.SetBool("Move", true);
       } else{
           animator.SetBool("Move", false);
       }
    }
    void HitAnimation(){
        animator.SetTrigger("Hit");
    }
    void DeathAnimation(){
        animator.SetTrigger("Death");
        Destroy(transform.parent.gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
    }
    void AttackAnimation(){
        animator.SetTrigger("Attack");
    }
}
