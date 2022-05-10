using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : State
{
    public bool playerVisable;
    public StateChase stateChase;

    public override State RunCurrentState()
    {
        if (playerVisable)
        {
            return stateChase;
        }
        else
        {
            return this;
        }
    }





}
