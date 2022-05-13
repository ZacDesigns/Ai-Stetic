using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AISteticAI
{

    [RequireComponent(typeof(NavMeshAgent), typeof(StateMachine))]
    public class EnemyMovementManager : MonoBehaviour
    {
        NavMeshAgent _navMeshAgent;
        StateMachine _stateMachine;

        private void Awake()
        {
            _navMeshAgent = this.GetComponent<NavMeshAgent>();
            _stateMachine = this.GetComponent<StateMachine>();
        }
 

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


