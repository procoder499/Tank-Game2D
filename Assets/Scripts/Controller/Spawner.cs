using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public GameObject explosionEffect;

    public GameControll gameController;
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        gameController.sumSpawner -= 1;
        Debug.Log(gameController.sumSpawner);
        Destroy(gameObject);

    }
}
