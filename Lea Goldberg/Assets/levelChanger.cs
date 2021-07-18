using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class levelChanger : MonoBehaviour
{
    public static levelChanger Instance;
    public GameObject fadePanel;
    private Animator animator;
    private int levelToLoad;
    private void Awake()
    {
        Instance = this;
        animator = fadePanel.GetComponent<Animator>();
    }
    public void FadeToNextLevel()
    {
        if (SceneManager.sceneCount >= SceneManager.GetActiveScene().buildIndex + 1)
            FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
        else
            ReplayScene();
    }
    public void FadeToPreviousScene()
    {
        if (SceneManager.GetSceneAt(SceneManager.GetActiveScene().buildIndex - 1) != null)
            FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ReplayScene()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
    public void onFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

