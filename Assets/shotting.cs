using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;     // Prefab del proyectil
    public Transform shootingPoint;         // Punto de origen del disparo
    public Camera playerCamera;             // C�mara en primera persona del jugador
    public float shootForce = 700f;         // Fuerza del disparo

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (projectilePrefab != null && shootingPoint != null && playerCamera != null)
        {
            // Instancia el proyectil en el punto de disparo
            GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Calcula la direcci�n hacia donde est� mirando la c�mara y aplica fuerza al proyectil en esa direcci�n
                Vector3 shootingDirection = playerCamera.transform.forward;
                rb.AddForce(shootingDirection * shootForce);
            }
        }
        else
        {
            Debug.LogWarning("Faltan referencias en el script de disparo.");
        }
    }
}

