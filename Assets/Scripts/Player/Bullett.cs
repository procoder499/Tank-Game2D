using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hitEffect;
    public int damage = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Item"))
        {
            Box box = collision.gameObject.GetComponent<Box>();
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            if (box != null)
            {
                box.TakeDamage(damage);
            }
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Brick") )
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
        else if ( collision.CompareTag("Spawner"))
        {
            Spawner spawner = collision.gameObject.GetComponent<Spawner>();
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            if (spawner != null)
            {
                spawner.TakeDamage(damage);
            }
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
    }
}
