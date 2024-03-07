using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject mainMenuUI;
    public GameObject uiOverlay;

    // Ensure all UI elements are initially turned off
    void Awake()
    {
        gameOverUI.SetActive(false);
        mainMenuUI.SetActive(false);
        uiOverlay.SetActive(false);
    }

    public void RestartLevel()
    {
        // Turn off game over UI and turn on UI overlay
        gameOverUI.SetActive(false);
        mainMenuUI.SetActive(false); // Ensure main menu UI is also off
        uiOverlay.SetActive(true);
    }

    public void MainMenu()
    {
        // Turn off game over UI and turn on main menu UI
        gameOverUI.SetActive(false);
        mainMenuUI.SetActive(true);
        uiOverlay.SetActive(false); // Ensure UI overlay is off
    }

    public void QuitGame()
    {
        // Turn off game over UI and quit the game
        gameOverUI.SetActive(false);
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
