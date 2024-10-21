using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Esta función se ejecuta cuando el enemigo colisiona con otro objeto
    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto que colisiona tiene el Tag "Projectile"
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Destruir el enemigo
            Destroy(gameObject);

            // Destruir el proyectil
            Destroy(collision.gameObject);
        }
    }
}
