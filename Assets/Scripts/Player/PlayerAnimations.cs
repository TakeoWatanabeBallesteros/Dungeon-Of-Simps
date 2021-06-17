using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    Vector2 direction, mousePos;

    private void OnEnable(){
        PlayerHealth.OnHit += HitAnimation;
        PlayerHealth.OnDeath += DeathAnimation;
        PlayerMovement.OnMove += MovingAnimation;
        PlayerAttack.OnAttack += AttackAnimation;
        GameFlowControler.Restart += ResetAniamtion;
    }
    private void OnDisable(){
        PlayerHealth.OnHit -= HitAnimation;
        PlayerHealth.OnDeath -= DeathAnimation;
        PlayerMovement.OnMove -= MovingAnimation;
        PlayerAttack.OnAttack -= AttackAnimation;
        GameFlowControler.Restart -= ResetAniamtion;
    }
    void Start()
    {
        Controls.controls.PlayerControls.Move.performed += ctx => direction = ctx.ReadValue<Vector2>();
        Controls.controls.PlayerControls.Move.canceled += ctx => direction = Vector2.zero;
        Controls.controls.PlayerControls.MouseAim.performed += ctx => mousePos = ctx.ReadValue<Vector2>();
        animator = GetComponent<Animator>();
    }
    public void MovingAnimation(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 aimDirection = (mousePosition - transform.position).normalized;
        animator.SetFloat("Vector_y", aimDirection.y);
        animator.SetFloat("Vector_x", aimDirection.x);
        //Idle
        if (PlayerMovement.rb.velocity.magnitude < 0.1f)
            animator.SetBool("Moving", false);
        //Moving
        else
            animator.SetBool("Moving", true);
    }
    public void HitAnimation(){
        animator.SetTrigger("Hit");
    }
    public void AttackAnimation(){
        animator.SetTrigger("Attack");
    }
    public void DeathAnimation(){
        animator.SetTrigger("Death");
    }
    void ResetAniamtion(){
        animator.SetTrigger("Restart");
    }
}
