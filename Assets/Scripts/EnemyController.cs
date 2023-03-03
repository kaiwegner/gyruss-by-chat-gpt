using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.down * speed;
    }
}