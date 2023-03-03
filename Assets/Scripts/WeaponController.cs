using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    public Transform bulletSpawnPoint;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
    }
}

