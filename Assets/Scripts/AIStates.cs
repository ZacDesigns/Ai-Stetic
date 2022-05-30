using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AiStateId
{
    ChasePlayer,
    Idle,
    Death

}
public interface AIStates
{
    AiStateId GetId();
    void Enter(AI_Agent agent);
    void Update(AI_Agent agent);
    void Exit(AI_Agent agent);
}
