using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeState : MonoBehaviour
{
    public delegate void OnMoveDelegate();
    public OnMoveDelegate OnMove;
    // Start is called before the first frame update
    public virtual void DodgeEnter(){}
    public virtual void DodgeUpdate(){}
    public virtual void DodgeExit(){}
}
