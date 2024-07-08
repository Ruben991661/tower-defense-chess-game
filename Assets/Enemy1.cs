using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Checkpoint checkpoint = other.GetComponent<Checkpoint>();
        if (checkpoint != null && checkpoint.isLastCheckpoint)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Implement your game over logic here
        Debug.Log("Game Over! The enemy reached the last checkpoint.");

        // Example of stopping the game:
        // 1. Stop enemy movements
        Time.timeScale = 0;

        // 2. Optionally, show a game over UI
        // GameOverUI.SetActive(true);
    }
}
