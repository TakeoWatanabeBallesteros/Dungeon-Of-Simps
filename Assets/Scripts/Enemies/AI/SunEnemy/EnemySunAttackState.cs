using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySunAttackState : AttackState
{
    
    public override void AttackEnter(){
        OnAttack?.Invoke();
    }
    public override void AttackUpdate(){
        OnMove?.Invoke();
    }
    public override void AttackExit(){

    }
}