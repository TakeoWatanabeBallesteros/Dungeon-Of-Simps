using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerAbilities : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rb;
    public float dashCoolDown, slowMoCoolDown, dashDistance;

    public delegate void OnDashDelegate();
    public static OnDashDelegate OnDash;
    public delegate void OnSlowMoDelegate();
    public static OnSlowMoDelegate OnSlowMo;
    public delegate void FinishSlowMoDelegate();
    public static FinishSlowMoDelegate FinishSlowMo;
    void Start()
    {
        Controls.controls.PlayerControls.Move.performed += ctx => direction = ctx.ReadValue<Vector2>();
        Controls.controls.PlayerControls.Move.canceled += _ => direction = Vector2.zero;
        Controls.controls.PlayerControls.Dash.performed += _ => Dash();
        Controls.controls.PlayerControls.SlowMotion.performed += _ => SlowMotion();
        rb = GetComponent<Rigidbody2D>();
        dashCoolDown = slowMoCoolDown = 0;
        dashDistance = 13f;
    }
    void Update()
    {
        if(dashCoolDown>=0)
        dashCoolDown-=Time.deltaTime;
        if(slowMoCoolDown>=0)
        slowMoCoolDown-=Time.deltaTime;
    }
    public void Dash(){
        if(dashCoolDown<=0){
            AudioManager.Instance.PlayGirlDashEvent();
            StartCoroutine(Dashing());
            OnDash?.Invoke();
        }
    }
    public void SlowMotion(){
        if(slowMoCoolDown<=0){
            StartCoroutine(SlowMo());
            OnSlowMo?.Invoke();
        }
    }
    IEnumerator Dashing(){
        PlayerMovement.CantMove?.Invoke();
        rb.AddForce(direction*dashDistance,ForceMode2D.Impulse);
        yield return new WaitForSeconds(.2f);
        PlayerMovement.CanMove?.Invoke();
        dashCoolDown = 3f;
    }
    IEnumerator SlowMo(){
        Time.timeScale = 0.4f;
        Time.fixedDeltaTime = Time.timeScale*0.02f;
        yield return new WaitForSecondsRealtime(4f);
        FinishSlowMo?.Invoke();
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
        slowMoCoolDown = 25f;
    }
}
