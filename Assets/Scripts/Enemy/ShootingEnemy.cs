using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shottingEnemy : MonoBehaviour
{
    public Transform player; 
    public float shootingRange = 10f; 
    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float fireRate = 1f;
    public float bulletForce = 20f;

    private float nextFireTime = 0f;

    void Update()
    {

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);


        if (distanceToPlayer <= shootingRange && Time.time >= nextFireTime)
        {
            Debug.Log("Distance <= Range");
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Debug.Log("EnemyShoot");
    }
}