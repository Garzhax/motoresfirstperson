using UnityEngine;

public class Projectile : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Si el proyectil choca con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destruir al enemigo
            Destroy(gameObject); // Destruir el proyectil
        }
    }
}
