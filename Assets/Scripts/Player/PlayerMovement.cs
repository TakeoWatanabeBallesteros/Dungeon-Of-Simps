using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem dust;
    public float speed;
    public static Rigidbody2D rb;
    Vector2 direction;
    public bool canMove;

    public delegate void OnMoveDelegate();
    public static OnMoveDelegate OnMove;
    public delegate void CanMoveDelegate();
    public static CanMoveDelegate CanMove;
    public delegate void CantMoveDelegate();
    public static CantMoveDelegate CantMove;
    public delegate void OnMovingDelegate();
    public static OnMovingDelegate OnMoving;
    public delegate void OnIdleDelegate();
    public static OnIdleDelegate OnIdle;
    private void OnEnable() {
        CanMove += _CanMove;
        CantMove += _CantMove;
    }
    private void OnDisable() {
        CanMove -= _CanMove;
        CantMove -= _CantMove;
    }
    void Start()
    {
        Controls.controls.PlayerControls.Move.performed += ctx => direction = ctx.ReadValue<Vector2>();
        Controls.controls.PlayerControls.Move.canceled += ctx => direction = Vector2.zero;   
        canMove = true;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() {
        if(IceFloor.onIce){
            MovingOnIce();
        } else if(canMove){
            Moving();
        }
        OnMove?.Invoke();
    }
    void Moving (){
        if(direction != Vector2.zero){
            rb.velocity = Vector2.Lerp(rb.velocity, direction*speed, 0.1f);
        }else{
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, 0.1f);
        }
        if(rb.velocity.magnitude > 0.1f){
            CreateDust();
            AudioManager.PlaySteps?.Invoke();
        }else{AudioManager.StopSteps?.Invoke();}
    }
    void MovingOnIce(){
        if(direction != Vector2.zero){
            rb.velocity = Vector2.Lerp(rb.velocity, direction*speed, 0.01f);
        }else{
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, 0.01f);
        }
    }
    void _CanMove(){ canMove = true;}
    void _CantMove(){ 
        canMove = false;
        AudioManager.StopSteps?.Invoke();
    }
    void CreateDust(){
        dust.Play();
    }
}
