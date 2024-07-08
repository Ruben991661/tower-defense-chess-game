using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtLastCheckpoint : MonoBehaviour
{
    public pathfinding pathfindingScript; // Reference to the pathfinding script

    void Update()
    {
        // Check if the current checkpoint index is equal to or greater than the length of checkpoints array
        if (pathfindingScript.currentCheckpointIndex >= pathfindingScript.checkpoints.Length)
        {
            // Destroy the game object
            Destroy(gameObject);
        }
    }
}

