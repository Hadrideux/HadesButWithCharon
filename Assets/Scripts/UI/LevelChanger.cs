using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator _animator = null;
    private int _levelToLoad;
    void Start()
    {

    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(1);
        }*/
    }
    public void FadeToLevel(int levelIndex)
    {
        _levelToLoad = levelIndex;
        _animator.SetTrigger("FadeOut");
    }

    public void FadeToLevels()
    {

        _animator.SetTrigger("FadeOut");
        SceneManager.LoadScene("GameScene");
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("GameScene");
        //SceneManager.LoadScene(_levelToLoad);
    }
}