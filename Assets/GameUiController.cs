using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    public Text timeText;          // Objeto de texto para el tiempo
    public Text healthText;        // Objeto de texto para la vida
    public GameObject loseText;    // Referencia al texto "You Lose"
    public float gameTime = 60f;   // Tiempo total del juego
    public int playerHealth = 100; // Vida inicial del jugador

    private float timeRemaining;

    void Start()
    {
        timeRemaining = gameTime;
        UpdateUI();
        loseText.SetActive(false);  // Asegurarse de que el texto de "You Lose" esté oculto al inicio
    }

    void Update()
    {
        // Actualizar el tiempo
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateUI();
        }
        else
        {
            // Cuando el tiempo llegue a cero, mostrar el cartel de "You Lose"
            timeRemaining = 0;
            loseText.SetActive(true);
            // Opcional: Pausar el juego
            Time.timeScale = 0f;
        }
    }

    void UpdateUI()
    {
        // Actualizar el texto del tiempo y de la vida
        timeText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
        healthText.text = "Health: " + playerHealth.ToString();
    }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if (playerHealth < 0) playerHealth = 0;
        UpdateUI();
    }
}
