using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public Board board;
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public bool paused = false;

    void Start()
    {
        pausePanel.SetActive(false);
        ResumeButton.SetActive(false);
        PauseButton.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        ResumeButton.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        PauseButton.SetActive(false);
        ResumeButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }
}
