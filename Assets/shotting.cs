using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab del proyectil
    public Transform shootingPoint;      // Punto desde donde se dispara (boquilla del arma)
    public Camera playerCamera;          // Cámara del jugador (para obtener la dirección de disparo)
    public float projectileSpeed = 20f;  // Velocidad del proyectil

    void Update()
    {
        // Detectar si se presiona el botón de disparo (botón izquierdo del mouse)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en la posición del punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);

        // Obtener la dirección en la que está mirando la cámara
        Vector3 shootDirection = playerCamera.transform.forward;

        // Añadir velocidad al proyectil en la dirección hacia donde apunta la cámara
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootDirection * projectileSpeed;
    }
}
