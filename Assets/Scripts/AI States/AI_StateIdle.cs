using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_StateIdle : AIStates
{
    public void Enter(AI_Agent agent)
    {

    }

    public void Exit(AI_Agent agent)
    {

    }

    public AiStateId GetId()
    {
        return AiStateId.Idle;
    }

    public void Update(AI_Agent agent)
    {
        Vector3 playerDirection = agent.playerTransform.position - agent.transform.position;
        if (playerDirection.magnitude > agent.config.maxSight)
        {
            return;
        }


        Vector3 agentDirection = agent.transform.forward;

        playerDirection.Normalize();

        float dotProduct = Vector3.Dot(playerDirection, agentDirection);
        if (dotProduct > 0.0f)
        {
            agent.stateMachine.ChangeState(AiStateId.ChasePlayer);
        }
    }
}
