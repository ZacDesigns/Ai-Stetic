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

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        stateMachine = new Ai_StateMachine(this);
        stateMachine.RegisterState(new AI_StateChase());
        stateMachine.ChangeState(initialState);
        //gameObject.GetComponent<NavMeshAgent>().SetDestination(start.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();

    }
}
