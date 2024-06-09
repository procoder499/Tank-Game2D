using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> EnemyList = new List<GameObject>();
    private bool check = true;
    private IEnumerator Spawn()
    {
        foreach (GameObject obj in EnemyList)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Coroutine ended.");
        check = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && check)
        {
            StartCoroutine(Spawn());
        }
    }
}
