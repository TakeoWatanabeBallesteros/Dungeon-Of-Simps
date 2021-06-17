using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1EnemyAI : BasicEnemyAI
{
    FSM<BasicEnemyState> brain;
    
    // Start is called before the first frame update
    AttackState attackState;
    PatrolState patrolState;
    EnemyVision enemyVision;
    void Awake(){
        attackState = GetComponent<AttackState>();
        patrolState = GetComponent<PatrolState>();
        enemyVision = GetComponent<EnemyVision>();
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
        brain.SetOnExit(BasicEnemyState.Attack, AttackExit);

    }
    // Update is called once per frame
    void Update(){
        brain.Update();
    }
    void AttackUpdate(){
        attackState.AttackUpdate();
        if(!enemyVision.onVision)
        brain.ChangeState(BasicEnemyState.Patrol);
    }
    void PatrolUpdate(){
        patrolState.PatrolAIUpdate();
        if(enemyVision.onVision)
        brain.ChangeState(BasicEnemyState.Attack);
    }
    void PatrolExit(){
        patrolState.PatrolExit();
    }
    void AttackExit(){
        attackState.AttackExit();
    }
    void AttackEnter(){
        EnemyAudioManager.Instance.PlayMiniMobEvent( 0, gameObject.transform.position);
        attackState.AttackEnter();
    }
}
