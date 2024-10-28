using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject winText; // Referencia al texto de victoria

    void Start()
    {
        winText.SetActive(false); // Asegurarse de que el texto esté oculto al inicio
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile")) // Si el enemigo es golpeado por un proyectil
        {
            ShowWinText(); // Llama a la función para mostrar el cartel de victoria
            Destroy(gameObject); // Destruye el enemigo
        }
    }

    void ShowWinText()
    {
        winText.SetActive(true); // Muestra el texto de victoria
        Time.timeScale = 0; // Pausa el juego
    }
}

