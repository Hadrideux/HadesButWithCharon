using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public static bool _isGameOverOpen = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

   public void Retry()
    {
        _isGameOverOpen=false;
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        _isGameOverOpen=false;
        SceneManager.LoadScene("MainMenuScene");
    }
}
