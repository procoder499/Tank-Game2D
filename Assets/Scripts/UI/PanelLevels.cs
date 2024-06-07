using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelLevels : MonoBehaviour
{
    public Button btnLv1;
    public Button btnLv2;
    public Button btnLv3;
    public Button btnLv4;
    public Button btnLv5;
    public Button btnQuit;

    public GameObject Bg;
    public GameObject panelPlay;
    public GameObject panelMain;
    public GameObject panelLevels;
    public GameObject panelLv1;
    public GameObject panelLv2;
    public GameObject panelLv3;
    public GameObject panelLv4;
    public GameObject panelLv5;
    void Start()
    {

        // Gán hàm xử lý sự kiện cho nút btnPlay
        btnLv1.onClick.AddListener(OnLv1ButtonClicked);
        btnLv2.onClick.AddListener(OnLv2ButtonClicked);
        btnLv3.onClick.AddListener(OnLv3ButtonClicked);
        btnLv4.onClick.AddListener(OnLv4ButtonClicked);
        btnLv5.onClick.AddListener(OnLv5ButtonClicked);
        btnQuit.onClick.AddListener(OnQuitButtonClicked);

    }

    // Hàm xử lý khi nhấn vào nút Play
    private void OnLv1ButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(false);
        panelLv1.SetActive(true);
        Bg.SetActive(false);
        panelPlay.SetActive(true);
    }
    private void OnLv2ButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(false);
        panelLv2.SetActive(true);
        Bg.SetActive(false);
        panelPlay.SetActive(true);
    }
    private void OnLv3ButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(false);
        panelLv3.SetActive(true);
        Bg.SetActive(false);
        panelPlay.SetActive(true);
    }
    private void OnLv4ButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(false);
        panelLv4.SetActive(true);
        Bg.SetActive(false);
        panelPlay.SetActive(true);
    }
    private void OnLv5ButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(false);
        panelLv5.SetActive(true);
        Bg.SetActive(false);
        panelPlay.SetActive(true);
    }
    private void OnQuitButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelMain.SetActive(true);
        panelLevels.SetActive(false);
    }
}
