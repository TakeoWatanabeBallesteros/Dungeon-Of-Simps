using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2DodgeState : DodgeState
{
    public override void DodgeEnter(){OnMove?.Invoke();}
    public override void DodgeUpdate(){}
    public override void DodgeExit(){}
}
