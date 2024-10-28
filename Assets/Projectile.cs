using UnityEngine;

public class Enemy : MonoBehaviour
{
    private VictoryController victoryController;

    void Start()
    {
        // Encuentra el VictoryController en la escena
        victoryController = FindObjectOfType<VictoryController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Llama a EnemyDestroyed en el VictoryController
            victoryController.EnemyDestroyed();

            // Destruye el enemigo
            Destroy(gameObject);
        }
    }
}
