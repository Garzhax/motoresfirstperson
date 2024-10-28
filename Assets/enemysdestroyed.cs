using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile")) // Si el enemigo colisiona con un proyectil
        {
            FindObjectOfType<VictoryCondition>().EnemyDestroyed(); // Llamar al m�todo en VictoryCondition
            Destroy(gameObject); // Destruir el enemigo
        }
    }
}
