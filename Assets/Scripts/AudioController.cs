using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioController : MonoBehaviour
{
    public List<GameObject> uiElements; // List of UI elements where audio can play
    public AudioSource audioSource;

    void Start()
    {
        // Ensure audio source is assigned
        if (audioSource == null)
        {
            Debug.LogError("Audio Source not assigned!");
            return;
        }

        // Initially stop the audio source
        audioSource.Stop();
    }

    void Update()
    {
        bool anyActive = false;

        // Check if any of the UI elements are active
        foreach (var element in uiElements)
        {
            if (element.activeInHierarchy)
            {
                anyActive = true;
                break;
            }
        }

        // Play or stop audio based on UI elements' status
        if (anyActive && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if (!anyActive && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
