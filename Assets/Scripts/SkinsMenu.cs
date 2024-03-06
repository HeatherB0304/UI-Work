using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsMenu : MonoBehaviour
{
    // Reference to the settings menu GameObject
    public GameObject skinsMenu;

    // Reference to the previous menu GameObject
    private GameObject previousMenu;

    // Function to turn off the settings menu and return to the previous menu
    public void ExitskinsMenu()
    {
        // Check if the settings menu GameObject is not null
        if (skinsMenu != null)
        {
            // Deactivate the settings menu GameObject
            skinsMenu.SetActive(false);

            // Check if there's a previous menu
            if (previousMenu != null)
            {
                // Activate the previous menu GameObject
                previousMenu.SetActive(true);
            }
        }
    }

    // Function to set the previous menu
    public void SetPreviousMenu(GameObject menu)
    {
        // Assign the menu as the previous menu
        previousMenu = menu;
    }
}
