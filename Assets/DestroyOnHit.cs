using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public string targetTag = "Destructible"; // Only destroy objects with this tag
    public float destroyDelay = 0f; // Delay before destroying
    public int scoreValue = 10; // Points awarded per destroyed object

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Increase the score
            ScoreManager.Instance.AddScore(scoreValue);

            // Destroy the object
            Destroy(collision.gameObject, destroyDelay);
        }

        // Destroy the projectile itself
        Destroy(gameObject);
    }
}
