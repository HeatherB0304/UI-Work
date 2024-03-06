using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject gameplayUI;
    public GameObject settingsMenu;
    public GameObject skinsMenu;
    public AudioSource buttonClickSound; // Reference to the AudioSource component

    public void PlayButtonClickSound()
    {
        // Play the button click sound
        buttonClickSound.Play();
    }
    public void ResumeGame()
    {
        // Hide the pause menu
        gameObject.SetActive(false);

        // Show the gameplay UI
        gameplayUI.SetActive(true);

        // Resume the game by setting the Time.timeScale back to 1
        Time.timeScale = 1f;
    }

    public void OpenSettingsMenu()
    {
        // Hide the pause menu
        gameObject.SetActive(false);

        // Show the settings menu
        settingsMenu.SetActive(true);
    }

    public void OpenSkinsMenu()
    {
        // Hide the pause menu
        gameObject.SetActive(false);

        // Show the skins menu
        skinsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
