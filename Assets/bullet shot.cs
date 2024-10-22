using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform shootingPoint; // Punto desde donde se disparan los proyectiles
    public float projectileSpeed = 20f; // Velocidad del proyectil

    void Update()
    {
        // Detectar cuando se presiona la barra espaciadora para disparar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en el punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
        // Obtener el Rigidbody del proyectil
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        // Aplicar fuerza hacia adelante al proyectil
        rb.velocity = shootingPoint.forward * projectileSpeed;
    }
}
