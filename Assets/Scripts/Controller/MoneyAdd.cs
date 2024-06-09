using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAdd : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SaveManager.instance.money += 100;
            SaveManager.instance.Save();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SaveManager.instance.money -= 100;
            SaveManager.instance.Save();
        }
    }
}
