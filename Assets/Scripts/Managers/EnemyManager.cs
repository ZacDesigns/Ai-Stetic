using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AISteticAI
{
    public class EnemyManager : MonoBehaviour
    {
        State _currentState; 
        StateIdle stateIdle = new StateIdle();


        void Start()
        {
            _currentState = stateIdle;
        }

        // Update is called once per frame
        void Update()
        {

        }




    }

}
