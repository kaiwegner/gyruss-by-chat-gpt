using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDelay = 1f;
    public float spawnRate = 1f;
    public Text scoreText;
    public Transform center;

    private int score;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnRate);
    }

    void SpawnEnemy()
    {
        var enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        if (enemyMovement != null)
        {
            enemyMovement.center = center;
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        // TODO: Game over logic
    }
}
