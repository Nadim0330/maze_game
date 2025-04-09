using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public PlayerStats stats;
    //public GameObject minimapIcon; // Assign icon if needed
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (stats != null)
            {
                stats.hasKey = true;

                // Optional: disable minimap icon
                //if (minimapIcon != null) minimapIcon.SetActive(false);

                // Optional visual feedback
                Debug.Log("Key Collected!");
                Destroy(gameObject); // remove the key from world

            }
        }
    }
}

