using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerProto : MonoBehaviour
{
    // Data import
    //private Rigidbody rigBod;

    //public float moveSpeed = 6; 
    //public Transform player;
    //private float x = 0;
    //private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        //rigBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //inputs
        //float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        //float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //movement
        //Vector3 movePos = transform.right * x + transform.forward * y;
        //Vector3 newMovePos = new Vector3(movePos.x, rigBod.velocity.y, movePos.z);

        //rigBod.velocity = newMovePos;
        //playerMove();
    }

    private void playerMove()
    {
        //inputs
        //float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        //float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //movement
       //Vector3 movePos = transform.right * x + transform.forward * y;
        //Vector3 newMovePos = new Vector3(movePos.x, rigBod.velocity.y, movePos.z);
        
        //rigBod.velocity = newMovePos;
    }

 
}
