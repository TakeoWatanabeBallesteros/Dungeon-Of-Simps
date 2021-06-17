using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2AttackState : AttackState
{
    public override void AttackEnter(){
        Shoot();
    }
    public override void AttackUpdate(){
        OnMove?.Invoke();
    }
    public override void AttackExit(){

    }
    void Shoot(){
        OnAttack?.Invoke();
    }
}
