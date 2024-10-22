using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform playerBody; // Referencia al cuerpo del jugador
    public float mouseSensitivity = 100f;
    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor en el centro
    }

    void Update()
    {
        // Rotación de la cámara basada en el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotar solo la cámara en el eje vertical
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limita la rotación vertical

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Rotar la cámara en el eje X (vertical)
        playerBody.Rotate(Vector3.up * mouseX); // Rotar el cuerpo del jugador en el eje Y (horizontal)
    }
}
