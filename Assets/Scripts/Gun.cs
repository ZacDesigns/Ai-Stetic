using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float Damage = 20f;
    public float Range = 150f;
    public Camera fpsCamera;


    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit))
        {
            EnemyHealthManager enemy = hit.transform.GetComponent<EnemyHealthManager>();
            Debug.Log(hit.transform.name);

            if(enemy != null)
            {
                enemy.TakeDamage(Damage);
            }
        }
    }


}