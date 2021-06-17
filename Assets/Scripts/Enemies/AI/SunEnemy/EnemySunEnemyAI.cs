using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySunEnemyAI : BasicEnemyAI
{
    FSM<BasicEnemyState> brain;
    AttackState attackState;
    void Awake() {
        attackState = GetComponent<AttackState>();
    }
    void Start()
    {
        brain = new FSM<BasicEnemyState>(BasicEnemyState.Patrol);
        //Patrol
        brain.SetOnStay(BasicEnemyState.Patrol, PatrolUpdate);
        brain.SetOnExit(BasicEnemyState.Patrol, PatrolExit);
        //Attack
        brain.SetOnEnter(BasicEnemyState.Attack, AttackEnter);
        brain.SetOnStay(BasicEnemyState.Attack, AttackUpdate);

    }
    // Update is called once per frame
    void Update(){
        brain.Update();
    }
    void AttackUpdate(){
        attackState.AttackUpdate();
    }
    void AttackEnter(){
        EnemyAudioManager.Instance.PlaySunEvent( 0, gameObject.transform.position);
        attackState.AttackEnter();
    }
    void PatrolUpdate(){
        brain.ChangeState(BasicEnemyState.Attack);
    }
    void PatrolExit(){
    }
}

