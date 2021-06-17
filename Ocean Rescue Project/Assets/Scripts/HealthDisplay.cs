using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class HealthDisplay : MonoBehaviour
{

    // This will be the Text component that displays the health value
    // Text = variable is in the form of a Text component
    Text healthValueDisplay;

    // This will be the PlayerHealth component that we can ask for information about the player's health
    // PlayerHealth = variable is in the form of a PlayerHealth component (your script)
    PlayerHealth player;

    // Built in Unity function
    // Start is called before the first frame update
    void Start()
    {
        // Get a Text component from the game object this script is attached to
        // Store the Text component in our healthValueDisplay variable
        healthValueDisplay = GetComponent<Text>();

        // Search the scene for the object with PlayerHealth script attached
        // Store the PlayerHealth component from that object in our player variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Built in Unity function
    // Update is called once per frame
    void Update()
    {
        // Get the current health value from the player using the GetHealth() function
        // Change that number to text using ToString()
        // On the health value display Text component, set the text to be the number we just got
        healthValueDisplay.text = player.GetHealth().ToString();
    }
}
