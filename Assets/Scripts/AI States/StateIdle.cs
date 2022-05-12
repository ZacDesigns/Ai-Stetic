using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName ="IdleState", menuName="Unity AI States/Idle", order =1)]

public class StateIdle : State
{
    public override bool EnterState()
    {
        base.EnterState();

        Debug.Log("Entered idle state");

        return true; 

    }

    public override void UpdateState()
    {
        Debug.Log("Updating Idle state");
    }

    public override bool ExitState()
    {
        base.ExitState();

        Debug.Log("Exited idle state");

        return true;
    }


}
