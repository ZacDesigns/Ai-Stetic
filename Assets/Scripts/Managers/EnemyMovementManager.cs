using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AISteticAI
{
    public class EnemyMovementManager : MonoBehaviour
    {
        EnemyManager enemyManager;
        LayerMask detectionLayer;

        private void Awake()
        {
            enemyManager = GetComponent<EnemyManager>();
        }
        public void HandleDetection()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, EnemyManager.detectionRadius, detectionLayer);
            for (int i = 0; i < colliders.Length; i++)
            {

            }

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


