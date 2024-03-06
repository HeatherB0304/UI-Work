using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject skinsMenu;
    public GameObject otherMenu;

    public void PlayGame()
    {
        // Deactivate the main menu
        gameObject.SetActive(false);

        // Activate the other menu
        otherMenu.SetActive(true);

        // Load the game scene
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettingsMenu()
    {
        // Enable the settings menu
        settingsMenu.SetActive(true);
    }

    public void OpenSkinsMenu()
    {
        // Enable the skins menu
        skinsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
