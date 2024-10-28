using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Rigidbody playerRigidbody; // Referencia al Rigidbody del jugador

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
    }

    void Update()
    {
        MovePlayer(); // Llamar a la función de movimiento en cada frame
    }

    void MovePlayer()
    {
        // Obtener las entradas del jugador
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento basado en la entrada
        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized * moveSpeed;

        // Aplicar el movimiento al Rigidbody
        playerRigidbody.MovePosition(transform.position + movement * Time.deltaTime);
    }
}
