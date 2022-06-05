using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    private PauseMenuController pauseControl;

    void Start()
    {
        pauseControl = GameObject.Find("Canvas").GetComponent<PauseMenuController>();
    }


    public void buttonResume()
    {
        pauseControl.pauseScreen.SetActive(false);
        PauseMenuController.isPaused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
