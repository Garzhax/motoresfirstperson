using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform shootingPoint; // Punto desde donde sale el disparo
    public float projectileSpeed = 20f; // Velocidad del proyectil

    void Update()
    {
        // Detectar si el jugador presiona el botón de disparo (botón izquierdo del mouse)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en el punto de disparo y con la misma rotación del arma
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);

        // Añadir velocidad al proyectil en la dirección que mira el arma
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootingPoint.forward * projectileSpeed;
    }
}
