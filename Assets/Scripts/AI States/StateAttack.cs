using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack : State
{
    public override State RunCurrentState()
    {
        Debug.Log("Attack has been made");
        return this;
    }
}
