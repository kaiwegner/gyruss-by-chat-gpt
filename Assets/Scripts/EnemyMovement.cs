using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float radius = 5f;
    public Transform center;

    private float angle = 0f;

    void Update()
    {
        angle += speed * Time.deltaTime;

        Vector3 offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f) * radius;
        transform.position = center.position + offset;
    }
}

