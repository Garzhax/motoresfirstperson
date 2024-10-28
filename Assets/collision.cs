using UnityEngine;

public class Enemy : MonoBehaviour
{
    public VictoryCondition victoryCondition; // Referencia al controlador de victoria

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            victoryCondition.EnemyDestroyed(); // Llama a la función de conteo en VictoryCondition
            Destroy(gameObject); // Destruye el enemigo
        }
    }
}

