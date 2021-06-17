using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // This will be the starting health for the player
    // Public = shown in the Unity editor and accessible from other scripts
    // int = whole number
    public int startingHealth;
    // Can be edited in Unity
    public string gameOverScene;


    // This will be the player's current health
    // and will change as the game goes on
    int currentHealth;

    // Built-in Unity function called when the script is created
    // Usually when the game starts
    // This happens BEFORE the Start()
    void Awake()
    {
        // Initialise our current health to be equal to our 
        // starting health at the beginning of the game
        currentHealth = startingHealth;
    }

    // NOT built in to Unity
    // We must call it ourselves
    // This will change the player's current health
    // And Kill() them if they 0 health or less
    // Public so other scripts can access it
    public void ChangeHealth(int changeAmount)
    {
        // Take our current health, add the change amount, and store 
        // the result back in the current health variable
        currentHealth = currentHealth + changeAmount;

        // Keep our current health between 0 and the starting health value
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        // If our health drops to 0, that means the player should die
        if (currentHealth <= 0)
        {
            // We call the Kill function to kill the player
            Kill();
        }
    }


    // This function is NOT built in to Unity
    // It will only be called manually by our own code
    // It must be marked "public" so our other scripts can access it
    public void Kill()
    {
        // This will destroy the gameObject that this script is attached to 
        Destroy(gameObject);

        // Load the gameover scene
        SceneManager.LoadScene(gameOverScene);
    }

    // Thsi function is a custom function
    // It is a getter function which gives info to the calling code
    // the int is the type of info that will be given
    public int GetHealth()
    {
        // return will give the following info back to the calling code
        return currentHealth;
    }

}
