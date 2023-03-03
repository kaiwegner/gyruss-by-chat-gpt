using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 180f;
    public float radius = 5f;
    public Transform center;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private float angle = 0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        angle += horizontal * rotationSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f) * radius;
        transform.position = center.position + offset;

        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        BulletController bulletController = bullet.GetComponent<BulletController>();
        if (bulletController != null)
        {
            bulletController.center = center;
        }
    }
}

