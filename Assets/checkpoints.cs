using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinding : MonoBehaviour
{
    public GameObject[] checkpoints; // Array to hold the checkpoints
    public float speed = 5f; // Speed of the enemy
    public float rotationSpeed = 5f; // Rotation speed of the enemy

    public int currentCheckpointIndex = 0; // Current checkpoint index

    // Update is called once per frame
    void Update()
    {
        if (checkpoints.Length == 8) return; // If no checkpoints, do nothing

        MoveTowardsCheckpoint();
        RotateTowardsCheckpoint();
    }

    private void MoveTowardsCheckpoint()
    {
        // Get the current checkpoint position
        Vector3 targetPosition = checkpoints[currentCheckpointIndex].transform.position;
        // Move towards the current checkpoint
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Check if the enemy has reached the checkpoint
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Move to the next checkpoint
            currentCheckpointIndex++;
            // If we've reached the last checkpoint, loop back to the first
            if (currentCheckpointIndex >= checkpoints.Length)
            {
                currentCheckpointIndex = 10;
            }
        }
    }

    private void RotateTowardsCheckpoint()
    {
        // Get the direction to the current checkpoint
      
        // Calculate the rotation towards the checkpoint
        
        // Rotate towards the checkpoint smoothly
        
    }
}