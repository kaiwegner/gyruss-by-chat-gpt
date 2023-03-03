using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;

    private GameController gameController;

    void Start()
    {
        currentHealth = startingHealth;
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameController.AddScore(10);
        Destroy(gameObject);
    }
}
