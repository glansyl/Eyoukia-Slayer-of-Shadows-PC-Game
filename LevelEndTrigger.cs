using UnityEngine;
using Cainos.PixelArtPlatformer_VillageProps;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject levelCompleteUI; // Assign the Level Complete UI in the Inspector
    public Chest chest;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the Player has the correct tag
        {
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            Animator playerAnimator = other.GetComponent<Animator>();
            chest.Open();
            GameManager.Instance.LevelCompelted();
            if (playerMovement != null)
            {
                playerMovement.enabled = false; // Disable player movement script
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.linearVelocity = Vector2.zero; // Stop the player instantly
                    rb.isKinematic = true; // Prevent further physics movement
                }
            }

            if (playerAnimator != null)
            {
                playerAnimator.enabled = false; // Completely stop animations
            }

            if (levelCompleteUI != null)
            {
                levelCompleteUI.SetActive(true); // Show the Level Complete UI
            }
        }
    }
}
