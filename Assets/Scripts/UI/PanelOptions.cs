using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelOptions : MonoBehaviour
{
    public Button btnQuit;

    public GameObject panelMain;
    public GameObject panelOptions;
    void Start()
    {

        // Gán hàm xử lý sự kiện cho nút btnPlay
        btnQuit.onClick.AddListener(OnQuitButtonClicked);

    }

    // Hàm xử lý khi nhấn vào nút Play
    private void OnQuitButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelMain.SetActive(true);
        panelOptions.SetActive(false);

    }
}
