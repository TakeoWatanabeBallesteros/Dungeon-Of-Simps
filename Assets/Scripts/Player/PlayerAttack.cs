using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    bool pressing = false, fireing = false;

    public delegate void OnAttackDelegate();
    public static OnAttackDelegate OnAttack;
    void Start()
    {
        Controls.controls.PlayerControls.Fire1.started +=_=>StartAttack();
        Controls.controls.PlayerControls.Fire1.canceled +=_=>EndAttack();
       animator = GetComponent<Animator>();
    }
    void StartAttack(){
        pressing = true;
        if(!fireing){
            //timer = 0.25f;
            AudioManager.Instance.PlayGirlFightEvent();
            StartCoroutine(Attack());
        }
    }
    void EndAttack(){
        pressing = false;
    }
    IEnumerator Attack(){
        fireing = true;
        while(pressing){
            AudioManager.Instance.PlayAttackMeleEvent();
            OnAttack?.Invoke();
            yield return new WaitForSeconds(.25f);
        }
        fireing = false;
    }
}
