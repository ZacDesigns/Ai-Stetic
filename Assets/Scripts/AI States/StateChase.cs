using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChase : State
{
    public StateAttack stateAttack;
    public bool inAttackRange;

    public override State RunCurrentState()
    {
        if (inAttackRange)
        {
            return stateAttack;
        }
        else
        {
            return this;
        }

    }
}
