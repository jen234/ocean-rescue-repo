using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Public variable
    public Text scoreDisplay;
    public bool shouldReset = false;
    public int winningScore;
    public string winningScene;

    // Private variables
    private static int scoreValue = 0;

    // Called by Unity the frame after this object is created
    void Start()
    {
        // Check if we should be reseting the score this scene
        if (shouldReset == true)
        {
            // Reset the score value back to 0
            scoreValue = 0;
        }

        // Update the display of the score based on the numerical value
        scoreDisplay.text = scoreValue.ToString();
    }


    // Function to add to the player's score
    // NOT automatically called by Unity - we need to call it ourselves in our code
    public void AddScore(int toAdd)
    {
        // Update the numerical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        // Update the display of the score based on the numerical
        scoreDisplay.text = scoreValue.ToString();

        // Check if the score is bigger than our win score
        if (scoreValue >= winningScore)
        {
            // Our score is a winning score! Load win scene!
            SceneManager.LoadScene(winningScene);
        }
    }
}