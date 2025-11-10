using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("How many points this enemy gives")]
    public int pointValue = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Add score
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(pointValue);
            }

            // Destroy bullet + enemy
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
