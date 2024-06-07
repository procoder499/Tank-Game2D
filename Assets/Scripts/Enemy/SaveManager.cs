using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public int money;
    public bool[] WeaponUnlocked = new bool[6] { true, false, false, false, false, false };

    public static SaveManager instance { get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;
        DontDestroyOnLoad(gameObject);
        Load();
        Debug.Log(UnityEngine.Application.persistentDataPath);

    }

    public void Load()
    {
        if (File.Exists(UnityEngine.Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(UnityEngine.Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            money = data.money;
            WeaponUnlocked = data.WeaponUnlocked;

            if (data.WeaponUnlocked == null)
                WeaponUnlocked = new bool[6] { true, false, false, false, false, false };

            file.Close();
        }
    }
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(UnityEngine.Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

        data.money = money;
        data.WeaponUnlocked = WeaponUnlocked;

        bf.Serialize(file, data);
        file.Close();
    }
    public int GetMoney()
    {
        return money;
    }
    public void ChangeMoney(int newMoney)
    {
        money = newMoney;
        Save();
    }
    public bool GetWea(int _index)
    {
        return WeaponUnlocked[_index];
    }
    public void ChangeWea(int _index, bool value)
    {
        WeaponUnlocked[_index] = value;
        Save();
    }
    public void ResetData()
    {
        // Xóa file dữ liệu đã lưu nếu tồn tại
        if (File.Exists(UnityEngine.Application.persistentDataPath + "/playerInfo.dat"))
        {
            File.Delete(UnityEngine.Application.persistentDataPath + "/playerInfo.dat");
        }

        // Đặt lại các giá trị mặc định
        money = 0;
        WeaponUnlocked = new bool[6] { true, false, false, false, false, false };

        // Lưu lại dữ liệu đã được đặt lại
        Save();
    }

    [System.Serializable]
    class PlayerData_Storage
    {
        public int money;
        public bool[] WeaponUnlocked = new bool[6];
    }
}
