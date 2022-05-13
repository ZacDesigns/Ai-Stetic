using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField]
    State _startingState;

    State _previousState;

    State _currentState;

    public void Awake()
    {
        _currentState = null;
    }

    // Start is called before the first frame update
    public void Start()
    {
        if(_startingState != null)
        {
            EnterState(_startingState);
        }
    }

    public void EnterState(State nextState)
    {
        if (nextState = null)
        {
            return;
        }

        _currentState = nextState;
        _currentState.EnterState();
    }





    // Update is called once per frame
   public void Update()
    {
        if(_currentState != null)
        {
            _currentState.UpdateState();
        }
    }
}
