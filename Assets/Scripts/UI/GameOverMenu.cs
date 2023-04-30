using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public static bool _isGameOverOpen = false;

   public void Retry()
    {
        _isGameOverOpen=false;
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        _isGameOverOpen=false;
        SceneManager.LoadScene("MainMenuScene");
    }
}
