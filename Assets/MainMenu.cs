using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Minigame 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Minigame 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Minigame 3");
    }

    public void Introduction()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
