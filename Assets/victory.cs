using UnityEngine;
using UnityEngine.UI; // Para mostrar texto en UI

public class VictoryCondition : MonoBehaviour
{
    public int totalEnemies; // Total de enemigos a destruir
    public int enemiesDestroyed; // Contador de enemigos destruidos
    public Text victoryText; // Referencia al texto de victoria en la UI

    void Start()
    {
        enemiesDestroyed = 0; // Inicializar el contador
        victoryText.gameObject.SetActive(false); // Ocultar el texto al inicio
    }

    void Update()
    {
        // Comprobar la condición de victoria
        if (enemiesDestroyed >= totalEnemies)
        {
            ShowVictoryMessage();
        }
    }

    public void EnemyDestroyed()
    {
        enemiesDestroyed++; // Aumentar el contador al destruir un enemigo
    }

    void ShowVictoryMessage()
    {
        victoryText.gameObject.SetActive(true); // Mostrar el mensaje de victoria
        victoryText.text = "¡Has ganado!"; // Mensaje de victoria
        Time.timeScale = 0; // Detener el juego (opcional)
    }
}
