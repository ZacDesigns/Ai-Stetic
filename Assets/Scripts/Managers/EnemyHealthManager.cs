using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    public float Health = 40f;


    public void TakeDamage(float amount)
    {
        Health -= amount;

        if (Health<= 0)
        {
            Score.scoreVal += 5;
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
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
