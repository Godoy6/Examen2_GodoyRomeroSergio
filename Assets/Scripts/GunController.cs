using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public BulletPool bulletPool;
    public float bulletSpeed = 30f;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        GameObject bullet = bulletPool.GetBullet();

        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.velocity = bullet.transform.forward * bulletSpeed;
    }
}