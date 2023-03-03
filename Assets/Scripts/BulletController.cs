using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10;

    public Transform center;
    private Rigidbody2D rb;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        direction = (center.position - transform.position).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, center.position) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
