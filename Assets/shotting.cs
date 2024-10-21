using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform shootingPoint; // Punto desde donde sale el disparo
    public float projectileSpeed = 20f; // Velocidad del proyectil

    void Update()
    {
        // Detectar si el jugador presiona el bot�n de disparo (bot�n izquierdo del mouse)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en el punto de disparo y con la misma rotaci�n del arma
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);

        // A�adir velocidad al proyectil en la direcci�n que mira el arma
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootingPoint.forward * projectileSpeed;
    }
}
