using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 2f; // Sensibilidad del movimiento del mouse
    private float rotationX = 0f; // Variable para almacenar la rotación en el eje X (vertical)

    void Update()
    {
        // Obtener el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * sensitivity; // Movimiento horizontal del mouse
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity; // Movimiento vertical del mouse

        // Actualizar la rotación en el eje X (para el movimiento hacia arriba/abajo)
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Limitar la rotación vertical a un máximo de 90 grados hacia arriba y abajo

        // Aplicar la rotación en el eje X (vertical) al objeto de la cámara
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        // Aplicar la rotación horizontal (eje Y) al cuerpo del jugador, rotando su posición en el eje Y
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
