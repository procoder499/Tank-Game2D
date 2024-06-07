using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int HpHealing;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MyHp HpPlayer = collision.gameObject.GetComponent<MyHp>();
            if (HpPlayer != null)
            {
                HpPlayer.Healing(HpHealing);
            }
            Destroy(gameObject);
        }
    }
}
