using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Agent : MonoBehaviour
{
    public GameObject start;
    public Ai_StateMachine stateMachine;
    public AiStateId initialState;
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public AI_StateConfig config;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
        stateMachine = new Ai_StateMachine(this);
        stateMachine.RegisterState(new AI_StateChase());
        stateMachine.RegisterState(new AI_StateIdle());
        stateMachine.RegisterState(new AI_StateDeath());
        stateMachine.ChangeState(initialState);
        //gameObject.GetComponent<NavMeshAgent>().SetDestination(start.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();

        if (Score.scoreVal == 50)
        {
            initialState = AiStateId.ChasePlayer;
            stateMachine.ChangeState(initialState);
        }
    }
}
