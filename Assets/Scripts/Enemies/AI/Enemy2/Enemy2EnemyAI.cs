using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2EnemyAI : MonoBehaviour
{
    public enum Enemy2State{
        Patrol,
        Attack,
        Dodge
    }
    FSM<Enemy2State> brain;
    public AttackState attackState;
    public PatrolState patrolState;
    public EnemyVision enemyVision;
    public DodgeState dodgeState;
    float timer = 3, _timer = 1;
    void Awake(){
        attackState = GetComponent<AttackState>();
        patrolState = GetComponent<PatrolState>();
        dodgeState = GetComponent<DodgeState>();
        enemyVision = GetComponent<EnemyVision>();
    }
    // Start is called before the first frame update
    void Start()
    {
        brain = new FSM<Enemy2State>(Enemy2State.Patrol);
        //Patrol
        brain.SetOnStay(Enemy2State.Patrol, PatrolUpdate);
        brain.SetOnExit(Enemy2State.Patrol, PatrolExit);
        //Dodge
        brain.SetOnEnter(Enemy2State.Dodge, DodgeEnter);
        brain.SetOnStay(Enemy2State.Dodge, DodgeUpdate);
        brain.SetOnExit(Enemy2State.Dodge, DodgeExit);
        //Attack
        brain.SetOnEnter(Enemy2State.Attack, AttackEnter);
        brain.SetOnStay(Enemy2State.Attack, AttackUpdate);
        brain.SetOnExit(Enemy2State.Attack, AttackExit);

        
    }
    // Update is called once per frame
    void Update(){
        brain.Update();
    }
    void AttackEnter(){
        EnemyAudioManager.Instance.PlayWitchEvent( 0, gameObject.transform.position);
        attackState.AttackEnter();
    }
    void AttackUpdate(){
        attackState.AttackUpdate();
        if(timer <= 0){
            brain.ChangeState(Enemy2State.Dodge);
            timer = 3;
        }else
            timer -= Time.deltaTime;
        if(!enemyVision.onVision)
        brain.ChangeState(Enemy2State.Patrol);
    }
    void AttackExit(){
    }
    void PatrolUpdate(){
        patrolState.PatrolAIUpdate();
        if(enemyVision.onVision)
        brain.ChangeState(Enemy2State.Attack);
    }
    void PatrolExit(){
        patrolState.PatrolExit();
    }
    void DodgeEnter(){
        dodgeState.DodgeEnter();
    }
    void DodgeUpdate(){
        if(_timer <= 0){
            brain.ChangeState(Enemy2State.Attack);
            _timer = 1;
        }else
            _timer -= Time.deltaTime;
    }
    void DodgeExit(){

    }
}
