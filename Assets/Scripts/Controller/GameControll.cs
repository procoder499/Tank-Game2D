using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class GameControll : MonoBehaviour
{
    public List<GameObject> spawners;
    public GameObject PanelGameVictory;
    public GameObject PanelGamePlay;
    public int sumSpawner;
    void Start()
    {
        PanelGameVictory.SetActive(false);

        spawners = new List<GameObject>(GameObject.FindGameObjectsWithTag("Spawner"));

        sumSpawner = spawners.Count;
    }

    void Update()
    {
        CheckWinCondition();
    }

    public void RemoveSpawner(GameObject spawner)
    {
        spawners.Remove(spawner);
        Destroy(spawner);
        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (sumSpawner == 0)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        PanelGameVictory.SetActive(true);
        PanelGamePlay.SetActive(false);
    }
}
