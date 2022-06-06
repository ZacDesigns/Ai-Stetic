using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private PauseMenuController pauseController;
    private PlayerController playerController;

    public float mouseSensitivity = 100f;
    public Transform playerModel;
    private float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        pauseController = GameObject.Find("Canvas").GetComponent<PauseMenuController>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        if (!PauseMenuController.isPaused && !GameManager.gameIsOver)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerModel.Rotate(Vector3.up * mouseX);
        }

    }
}
