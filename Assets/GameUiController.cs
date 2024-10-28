using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    public Text enemyCountText;
    public Text healthText;
    public Text timeText;
    private int totalEnemies = 3; // Puedes ajustar según la cantidad total de enemigos
    private int enemiesDestroyed = 0;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (enemyCountText != null)
            enemyCountText.text = "Enemies: " + enemiesDestroyed + "/" + totalEnemies;

        if (healthText != null)
            healthText.text = "Health: 100"; // Ajusta el valor según la lógica del juego

        if (timeText != null)
            timeText.text = "Time: 60s"; // Ajusta el tiempo restante
    }

    public void EnemyDestroyed()
    {
        enemiesDestroyed++;
        UpdateUI();
    }
}
