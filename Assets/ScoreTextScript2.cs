using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextScript2 : MonoBehaviour
{
    public enum PlayerStates
    {
        IDLE,
        WALKING,
        RUNNING,
        SHOOTING
    }

    public PlayerStates playerStates;

    private TextMesh textMesh;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the TextMesh component
        textMesh = GetComponent<TextMesh>();
        if (textMesh == null)
        {
            Debug.LogError("TextMesh component not found!");
        }

        score = 0; // Initialize score
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerStates)
        {
            case PlayerStates.IDLE:
                // Add your logic for IDLE state
                break;
            case PlayerStates.WALKING:
                // Add your logic for WALKING state
                break;
            case PlayerStates.RUNNING:
                // Add your logic for RUNNING state
                break;
            case PlayerStates.SHOOTING:
                // Add your logic for SHOOTING state
                break;
        }

        // Example logic to update score
        // This should be replaced with your actual game logic
        score++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (textMesh != null)
        {
            textMesh.text = "Score: " + score;
        }
    }
}
