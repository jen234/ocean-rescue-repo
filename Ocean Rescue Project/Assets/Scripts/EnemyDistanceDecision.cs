using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{
    // ------------------------------------------------
    // Public variables, visible in Unity Inspector
    // Use these for settings for your script
    // that can be changed easily
    // ------------------------------------------------
    public float distanceForDecision;   // How close must the player be to change behaviour
    public Transform target;            // The thing you want to measure distance from


    // ------------------------------------------------
    // Private variables, NOT visible in the Inspector
    // Use these for tracking data while the game
    // is running
    // ------------------------------------------------
    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;


    // ------------------------------------------------
    // Awake is called when the script is loaded
    // ------------------------------------------------
    void Awake()
    {
        // Get the EnemyPatrol that we'll be using for AI
        patrolBehaviour = GetComponent<EnemyPatrol>();
        // Get the EnemyPatrol that we'll be using for AI
        chaseBehaviour = GetComponent<EnemyChase>();

        // Turn off the chase behaviour to start with:
        chaseBehaviour.enabled = false;
    }

    // ------------------------------------------------
    // Update is called once per frame
    // ------------------------------------------------
    void Update()
    {
        // How far away are we from the target?
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        // If we are closer to our target than our minimum distance...
        if (distance <= distanceForDecision)
        {
            // Disable patrol and enable chasing
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
        else
        {
            // Enable patrol and disable chasing
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
        }

    }
}
