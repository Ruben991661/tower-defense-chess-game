using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject losingScreen; // Assign the LosingScreenCanvas in the Inspector
    private bool gameLost = false;

    void Start()
    {
        losingScreen.SetActive(false); // Hide the losing screen at the start
    }

    public void EnemyReachedEnd()
    {
        if (!gameLost)
        {
            gameLost = true;
            losingScreen.SetActive(true); // Show the losing screen
            Time.timeScale = 0f; // Pause the game
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void MainMenu()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene("MainMenu"); // Load the main menu scene (make sure to create this scene)
    }
}
