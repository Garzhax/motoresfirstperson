using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public GameObject winText; // Texto de victoria
    private int enemiesDestroyed = 0; // Contador de enemigos destruidos
    public int totalEnemies = 3; // Total de enemigos necesarios para ganar

    void Start()
    {
        winText.SetActive(false); // Asegura que el texto esté oculto al inicio
    }

    // Función pública para incrementar el contador de enemigos
    public void EnemyDestroyed()
    {
        enemiesDestroyed++;

        if (enemiesDestroyed >= totalEnemies)
        {
            ShowWinText(); // Muestra el mensaje de victoria cuando todos los enemigos hayan sido destruidos
        }
    }

    void ShowWinText()
    {
        winText.SetActive(true); // Muestra el texto de victoria
        Time.timeScale = 0; // Pausa el juego
    }
}
