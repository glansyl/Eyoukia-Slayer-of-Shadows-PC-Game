using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // Use OnTriggerEnter for 2D
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth player = collision.GetComponent<PlayerHealth>();
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (player != null)
            {
                player.TakeDamage(playerMovement.currentHealth);
            }
        }
    }
}