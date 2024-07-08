using UnityEngine;

public class EnemyEnd : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndPoint"))
        {
            gameManager.EnemyReachedEnd();
            Destroy(gameObject); // Optional: Destroy the enemy when it reaches the end
        }
    }
}
