using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public GameObject explosionEffect;
    public GameObject item;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            BoxItem();
        }
    }
    private void BoxItem()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }
        item.SetActive(true);
        Destroy(gameObject);

    }

}
