using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AttackState : MonoBehaviour
{
    
    public delegate void OnAttackDelegate();
    public OnAttackDelegate OnAttack;
    public delegate void OnMoveDelegate();
    public OnMoveDelegate OnMove;
    
    public virtual void AttackEnter(){}
    public virtual void AttackUpdate(){}
    public virtual void AttackExit(){}
    
    
    
}
