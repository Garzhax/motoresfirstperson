using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 2f; // Sensibilidad del movimiento del mouse
    private float rotationX = 0f; // Variable para almacenar la rotaci�n en el eje X (vertical)

    void Update()
    {
        // Obtener el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * sensitivity; // Movimiento horizontal del mouse
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity; // Movimiento vertical del mouse

        // Actualizar la rotaci�n en el eje X (para el movimiento hacia arriba/abajo)
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Limitar la rotaci�n vertical a un m�ximo de 90 grados hacia arriba y abajo

        // Aplicar la rotaci�n en el eje X (vertical) al objeto de la c�mara
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        // Aplicar la rotaci�n horizontal (eje Y) al cuerpo del jugador, rotando su posici�n en el eje Y
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
