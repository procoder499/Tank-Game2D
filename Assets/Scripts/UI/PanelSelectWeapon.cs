using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    [SerializeField] private Button buy2;
    [SerializeField] private Button buy3;
    [SerializeField] private Button buy4;
    [SerializeField] private Button buy5;

    [SerializeField] private int[] WeaPrices;

    public Button btnWeapon1;
    public Button btnWeapon2;
    public Button btnWeapon3;
    public Button btnWeapon4;
    public Button btnWeapon5;
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Weapon3;
    public GameObject Weapon4;
    public GameObject Weapon5;
    public GameObject parentObject;

    public GameObject panelSelectWeapon;
    void Start()
    {
        if (SaveManager.instance.GetWea(1))
        {
            buy2.gameObject.SetActive(false);
            btnWeapon2.gameObject.SetActive(true);
        }
        if (SaveManager.instance.GetWea(2))
        {
            buy3.gameObject.SetActive(false);
            btnWeapon3.gameObject.SetActive(true);
        }
        if (SaveManager.instance.GetWea(3))
        {
            buy4.gameObject.SetActive(false);
            btnWeapon4.gameObject.SetActive(true);
        }
        if (SaveManager.instance.GetWea(4))
        {
            buy5.gameObject.SetActive(false);
            btnWeapon5.gameObject.SetActive(true);
        }
        Debug.Log(SaveManager.instance.GetMoney());
        buy2.onClick.AddListener(buy2ButtonCliked);
        buy3.onClick.AddListener(buy3ButtonCliked);
        buy4.onClick.AddListener(buy4ButtonCliked);
        buy5.onClick.AddListener(buy5ButtonCliked);
        btnWeapon1.onClick.AddListener(Weapon1ButtonClicked);
        btnWeapon2.onClick.AddListener(Weapon2ButtonClicked);
        btnWeapon3.onClick.AddListener(Weapon3ButtonClicked);
        btnWeapon4.onClick.AddListener(Weapon4ButtonClicked);
        btnWeapon5.onClick.AddListener(Weapon5ButtonClicked);
    }
    private void buy2ButtonCliked()
    {
        if (SaveManager.instance.GetMoney() >= WeaPrices[1])
        {
            buy2.gameObject.SetActive(false);
            btnWeapon2.gameObject.SetActive(true);
            SaveManager.instance.ChangeMoney(SaveManager.instance.GetMoney() - 300);
            SaveManager.instance.ChangeWea(1, true);
        }
    }
    private void buy3ButtonCliked()
    {
        if (SaveManager.instance.GetMoney() >= WeaPrices[2])
        {
            buy3.gameObject.SetActive(false);
            btnWeapon3.gameObject.SetActive(true);
            SaveManager.instance.ChangeMoney(SaveManager.instance.GetMoney() - 400);
            SaveManager.instance.ChangeWea(2, true);
        }
    }
    private void buy4ButtonCliked()
    {
        if (SaveManager.instance.GetMoney() >= WeaPrices[3])
        {
            buy4.gameObject.SetActive(false);
            btnWeapon4.gameObject.SetActive(true);
            SaveManager.instance.ChangeMoney(SaveManager.instance.GetMoney() - 1000);
            SaveManager.instance.ChangeWea(3, true);
        }
    }
    private void buy5ButtonCliked()
    {
        if (SaveManager.instance.GetMoney() >= WeaPrices[4])
        {
            buy5.gameObject.SetActive(false);
            btnWeapon5.gameObject.SetActive(true);
            SaveManager.instance.ChangeMoney(SaveManager.instance.GetMoney() - 2000);
            SaveManager.instance.ChangeWea(4, true);
        }
    }
    private void Weapon1ButtonClicked()
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        Weapon1.SetActive(true);
        panelSelectWeapon.SetActive(false);
    }
    private void Weapon2ButtonClicked()
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        Weapon2.SetActive(true);
        panelSelectWeapon.SetActive(false);
    }
    private void Weapon3ButtonClicked()
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        Weapon3.SetActive(true);
        panelSelectWeapon.SetActive(false);
    }
    private void Weapon4ButtonClicked()
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        Weapon4.SetActive(true);
        panelSelectWeapon.SetActive(false);
    }
    private void Weapon5ButtonClicked()
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        Weapon5.SetActive(true);
        panelSelectWeapon.SetActive(false);
    }
        public void OnResetButtonClick()
        {
            if (SaveManager.instance != null)
            {
                SaveManager.instance.ResetData();
            }
            else
            {
                Debug.LogError("SaveManager instance is not found!");
            }
        }
   
}
