using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject); // Destruye el enemigo solo si colisiona con un proyectil
        }
    }
}
