using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3AttackState : AttackState
{
    float timer = 0;
    public override void AttackEnter(){

    }
    public override void AttackUpdate(){
        OnMove?.Invoke();
        Shoot();
    }
    public override void AttackExit(){

    }
    void Shoot(){
        if(timer <= 0){
            OnAttack?.Invoke();
            timer = 3;
        }
        else
            timer -= Time.deltaTime;
    }
}
