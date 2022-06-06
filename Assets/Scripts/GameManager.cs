using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public static bool gameIsOver = false;
    public Score score;
    public Text scoreGameOver;


    void Start()
    {
        score.GetComponent<Score>();
        GameOverScreen.SetActive(false);
    }
    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            GameOverScreen.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }



}
