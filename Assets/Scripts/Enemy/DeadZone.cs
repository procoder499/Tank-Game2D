using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> EnemyList = new List<GameObject>();
    private IEnumerator Spawn()
    {
        foreach (GameObject obj in EnemyList)
        {
            yield return new WaitForSeconds(1f);
            obj.SetActive(true);
        }
        Debug.Log("Coroutine ended.");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Spawn());
        }
    }
}
