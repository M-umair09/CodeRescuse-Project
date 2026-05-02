using UnityEngine;
using TMPro; // Use this if you are using TextMeshPro

public class GameOverTrigger : MonoBehaviour
{
    // Drag your Game Over Text or Panel here in the Inspector
    public GameObject gameOverMessage;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the Player
        if (other.CompareTag("Player"))
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverMessage.SetActive(true); // Shows the message
        Time.timeScale = 0f;            // Optional: Pauses the game
    }
}
