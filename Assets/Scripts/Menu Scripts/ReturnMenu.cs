using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{




    public void buttonReturnMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        Score.scoreVal = 0;
        PauseMenuController.isPaused = false;
        GameManager.gameIsOver = false;
    }



}
