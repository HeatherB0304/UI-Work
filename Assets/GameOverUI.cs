using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameplayOverlayUI;
    public GameObject mainMenuUI;

    public void RestartLevel()
    {
        // Turn off Game Over UI
        gameOverUI.SetActive(false);

        // Turn on Gameplay Overlay UI
        gameplayOverlayUI.SetActive(true);
    }

    public void GoToMainMenu()
    {
        // Turn off Game Over UI
            gameOverUI.SetActive(false);

        // Turn on Main Menu UI
            mainMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
