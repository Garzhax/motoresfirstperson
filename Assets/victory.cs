using UnityEngine;
using UnityEngine.UI;

public class VictoryCondition : MonoBehaviour
{
    public int totalEnemies; // Total de enemigos
    private int enemiesDestroyed = 0; // Enemigos destruidos
    public Text victoryText; // Texto de victoria

    void Start()
    {
        victoryText.gameObject.SetActive(false); // Ocultar el texto de victoria al inicio
    }

    public void EnemyDestroyed()
    {
        enemiesDestroyed++; // Incrementar el contador de enemigos destruidos
        CheckVictoryCondition(); // Comprobar la condición de victoria
    }

    void CheckVictoryCondition()
    {
        if (enemiesDestroyed >= totalEnemies) // Si se han destruido todos los enemigos
        {
            ShowVictoryMessage(); // Mostrar el mensaje de victoria
        }
    }

    void ShowVictoryMessage()
    {
        victoryText.gameObject.SetActive(true); // Activar el texto de victoria
        Time.timeScale = 0; // Pausar el juego
    }
}
