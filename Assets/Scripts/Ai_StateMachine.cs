using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_StateMachine
{
    public AIStates[] states;
    public AI_Agent agent;
    public AiStateId currentState;

    public Ai_StateMachine(AI_Agent agent)
    {
        this.agent = agent;
        int numStates = System.Enum.GetNames(typeof(AiStateId)).Length;
        states = new AIStates[numStates];
    }

    public void RegisterState(AIStates state)
    {
        int index = (int)state.GetId();
        states[index] = state;
    }
    
    public AIStates GetState(AiStateId stateId)
    {
        int index = (int)stateId;
        return states[index];
    }

    public void Update()
    {
        GetState(currentState)?.Update(agent);
    }

    public void ChangeState(AiStateId newState)
    {
        GetState(currentState)?.Exit(agent);
        currentState = newState;
        GetState(currentState)?.Enter(agent);
    }


}
