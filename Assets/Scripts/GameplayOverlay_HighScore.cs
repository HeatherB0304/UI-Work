using UnityEngine;
using TMPro;

public class GameplayOverlay_HighScore : MonoBehaviour
{
    public TMP_Text highScoreText;
    public TMP_Text currentTimeText;
    public GameObject pauseMenu;

    private float currentTime = 0f;
    private float highScoreTime = 0f;
    private bool isPaused = false;

    void Start()
    {
        // Initialize high score time
        highScoreTime = PlayerPrefs.GetFloat("HighScoreTime", 0f);
        UpdateHighScoreText();
    }

    void Update()
    {
        if (!isPaused)
        {
            // Update current time
            currentTime += Time.deltaTime;
            UpdateCurrentTimeText();
        }

        // Check for ESC key to pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            TogglePauseMenu(isPaused);
            Time.timeScale = isPaused ? 0f : 1f;
        }
    }

    void UpdateCurrentTimeText()
    {
        // Update the current time text
        currentTimeText.text = "Current Time: " + FormatTime(currentTime);
    }

    void UpdateHighScoreText()
    {
        // Update the high score time text
        highScoreText.text = "High Score: " + FormatTime(highScoreTime);
    }

    void TogglePauseMenu(bool showMenu)
    {
        // Activate/deactivate the pause menu
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(showMenu);
        }
        else
        {
            Debug.LogError("Pause menu GameObject is not assigned!");
        }
    }

    string FormatTime(float timeInSeconds)
    {
        // Format time in minutes and seconds
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        string formattedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        return formattedTime;
    }

    public void UpdateHighScore()
    {
        // Update high score if the current time is greater
        if (currentTime > highScoreTime)
        {
            highScoreTime = currentTime;
            PlayerPrefs.SetFloat("HighScoreTime", highScoreTime);
            UpdateHighScoreText();
        }
    }
}
