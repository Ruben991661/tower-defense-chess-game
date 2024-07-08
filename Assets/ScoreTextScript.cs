using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextScript : MonoBehaviour
{
    // Define an enum named PlayerStates
    public enum PlayerStates
    {
        IDLE,
        WALKING,
        RUNNING,
        SHOOTING
    }

    public PlayerStates playerStates;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code, if any
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerStates)
        {
            case PlayerStates.IDLE:
                // Logic for IDLE state
                break;
            case PlayerStates.WALKING:
                // Logic for WALKING state
                break;
            case PlayerStates.RUNNING:
                // Logic for RUNNING state
                break;
            case PlayerStates.SHOOTING:
                // Logic for SHOOTING state
                break;
        }
    }
}
