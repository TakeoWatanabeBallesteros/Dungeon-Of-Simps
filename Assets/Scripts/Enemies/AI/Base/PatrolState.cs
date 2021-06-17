using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour
{
    [HideInInspector]
    public PatrolAI patrolAI;

    private void Start() {
        patrolAI = GetComponent<PatrolAI>();
    }

    public virtual void PatrolEnter(){}
    public virtual void PatrolAIUpdate(){}
    public virtual void PatrolExit(){}
}
