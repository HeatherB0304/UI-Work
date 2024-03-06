using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource buttonClickSound; // Reference to the AudioSource component for button click sound

    public void PlayButtonClickSound()
    {
        // Play the button click sound
        buttonClickSound.Play();
    }
}
