using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    private Rigidbody rb; // Referencia al componente Rigidbody del jugador

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Leer la entrada del teclado
        float moveHorizontal = Input.GetAxis("Horizontal"); // A y D para izquierda y derecha
        float moveVertical = Input.GetAxis("Vertical"); // W y S para adelante y atrás

        // Crear un vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplicar el movimiento al Rigidbody
        rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}
