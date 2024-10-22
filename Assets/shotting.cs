using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab del proyectil
    public Transform shootingPoint;      // Punto desde donde se dispara (boquilla del arma)
    public Camera playerCamera;          // C�mara del jugador (para obtener la direcci�n de disparo)
    public float projectileSpeed = 20f;  // Velocidad del proyectil

    void Update()
    {
        // Detectar si se presiona el bot�n de disparo (bot�n izquierdo del mouse)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en la posici�n del punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);

        // Obtener la direcci�n en la que est� mirando la c�mara
        Vector3 shootDirection = playerCamera.transform.forward;

        // A�adir velocidad al proyectil en la direcci�n hacia donde apunta la c�mara
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootDirection * projectileSpeed;
    }
}
