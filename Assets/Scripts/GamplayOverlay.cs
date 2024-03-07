using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text countdownText; // Assign this in the inspector
    public TMP_Text elapsedTimeText; // Assign this in the inspector
    public GameObject gameOverUI; // Assign the game over UI element in the inspector
    public GameObject pauseMenuUI; // Assign the pause menu UI element in the inspector
    public Button resumeButton; // Assign the resume button in the inspector

    public float countdownTime = 60f; // Time in seconds for countdown timer
    private float elapsedTime = 0f; // Time elapsed since start of level
    private bool isGameOver = false; // Flag to track game over state
    private bool isPaused = false; // Flag to track pause state

    void Start()
    {
        // Add listener to the resume button
        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeGame);
        }
    }

    void Update()
    {
        if (!isGameOver && !isPaused)
        {
            // Countdown timer logic
            countdownTime -= Time.deltaTime;
            if (countdownTime <= 0f)
            {
                countdownTime = 0f;
                GameOver();
            }
            UpdateCountdownText();

            // Elapsed time logic
            elapsedTime += Time.deltaTime;
            UpdateElapsedTimeText();
        }

        // Check for pause input
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void UpdateCountdownText()
    {
        int minutes = Mathf.FloorToInt(countdownTime / 60f);
        int seconds = Mathf.FloorToInt(countdownTime % 60f);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        Debug.Log("Countdown Time: " + countdownTime);
    }

    void UpdateElapsedTimeText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        elapsedTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        // Activate the game over UI element
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
            Debug.Log("Menu Turned On.");
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenuUI.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f; // Freeze/unfreeze time
    }

    void ResumeGame()
    {
        TogglePause(); // Hide pause menu
    }
}
