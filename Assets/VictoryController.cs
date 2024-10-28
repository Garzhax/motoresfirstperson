using UnityEngine;
using UnityEngine.UI;

public class VictoryController : MonoBehaviour
{
    public Text victoryText; // Campo público para arrastrar el texto de victoria en el Inspector
    private int totalEnemies = 3;
    private int destroyedEnemies = 0;

    void Start()
    {
        victoryText.gameObject.SetActive(false); // Oculta el texto al iniciar
    }

    public void EnemyDestroyed()
    {
        destroyedEnemies++;
        if (destroyedEnemies >= totalEnemies)
        {
            victoryText.gameObject.SetActive(true); // Muestra el cartel de victoria
        }
    }
}
