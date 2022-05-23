using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_StateChase : AIStates
{
    public Transform playerTransform;
    float timer = 0.0f;
    public Animator animator;

    public AiStateId GetId()
    {
        return AiStateId.ChasePlayer;
    }

    public void Enter(AI_Agent agent)
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    public void Exit(AI_Agent agent)
    {

    }

    public void Update(AI_Agent agent)
    {
        if (!agent.enabled)
        {
            return;
        }

        timer -= Time.deltaTime;
        if (!agent.navMeshAgent.hasPath)
        {
            agent.navMeshAgent.destination = playerTransform.position;
        }

        if (timer < 0.0f)
        {
            Vector3 direction = (playerTransform.position - agent.navMeshAgent.destination);
            direction.y = 0;
            if (direction.sqrMagnitude > agent.config.maxDistance * agent.config.maxDistance)
            {
                if (agent.navMeshAgent.pathStatus != NavMeshPathStatus.PathPartial)
                {

                }
            }
        }
        if (agent.navMeshAgent.hasPath)
        {
            animator.SetFloat("Speed", agent.navMeshAgent.velocity.magnitude);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
