using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraPrototype : MonoBehaviour
{
    private PlayerControllerProto playerController;
    public float mouseSensitivity = 10f;

    public Transform player;
    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Remove cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerCamera();
    }

    private void playerCamera()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerProto>();
        //Mouse look 
        x += -Input.GetAxis("Mouse Y") * mouseSensitivity;
        y += Input.GetAxis("Mouse X") * mouseSensitivity;

        //MathfClamp
        x = Mathf.Clamp(x, -90, 90);

        //rotations
        transform.localRotation = Quaternion.Euler(x, 0, 0);
        player.transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
