using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour
{
    public enum BasicEnemyState{
        Patrol,
        Attack
    }
    FSM<BasicEnemyState> brain;
    
    // Start is called before the first frame update
    void Start()
    {
        brain = new FSM<BasicEnemyState>(BasicEnemyState.Patrol);
        //Enter Actions
        brain.SetOnEnter(BasicEnemyState.Attack, AttackEnter);
        //Stay Actions
        brain.SetOnStay(BasicEnemyState.Patrol, PatrolUpdate);
        brain.SetOnStay(BasicEnemyState.Attack, AttackUpdate);
        //Exit Actions
        brain.SetOnExit(BasicEnemyState.Patrol, PatrolExit);
        brain.SetOnExit(BasicEnemyState.Attack, AttackExit);
    }

    // Update is called once per frame
    void Update(){
        brain.Update();
    }
    void AttackEnter(){
    }
    void AttackUpdate(){
    }
    void PatrolUpdate(){
    }
    void PatrolExit(){
    }
    void AttackExit(){
    }
}
