using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1PatrolState : PatrolState
{
    public override void PatrolEnter(){}
    public override void PatrolAIUpdate(){
        patrolAI.PatrolAIUpdate();
    }
    public override void PatrolExit(){}
}
