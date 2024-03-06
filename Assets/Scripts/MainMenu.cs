using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject settingsMenuUI;
    public GameObject skinsMenuUI;
    public GameObject gameplayUI;

    private void Start()
    {
        // Ensure that the main menu UI is initially active, and others are inactive
        mainMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        skinsMenuUI.SetActive(false);
        gameplayUI.SetActive(false);
    }

    public void OnPlayButtonPressed()
    {
        // Turn off main menu UI and turn on gameplay UI
        mainMenuUI.SetActive(false);
        gameplayUI.SetActive(true);
    }

    public void OnSettingsButtonPressed()
    {
        // Turn off main menu UI and turn on settings menu UI
        mainMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void OnSkinsButtonPressed()
    {
        // Turn off main menu UI and turn on skins menu UI
        mainMenuUI.SetActive(false);
        skinsMenuUI.SetActive(true);
    }

    public void OnQuitButtonPressed()
    {
        // Quit the game
        Application.Quit();
    }
}
