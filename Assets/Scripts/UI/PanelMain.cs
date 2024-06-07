using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelMain : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnPlay;
    public Button btnOption;
    public Button btnQuit;

    public GameObject panelMain;
    public GameObject panelLevels;
    public GameObject panelOptions;
    void Start()
    {
        // Ẩn panelLevels khi bắt đầu
        panelLevels.SetActive(false);

        // Gán hàm xử lý sự kiện cho nút btnPlay
        btnPlay.onClick.AddListener(OnPlayButtonClicked);
        btnOption.onClick.AddListener(OnOptionButtonClicked);

    }

    // Hàm xử lý khi nhấn vào nút Play
    private void OnPlayButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelLevels.SetActive(true);
        panelMain.SetActive(false);

    }
    private void OnOptionButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelOptions.SetActive(true);
        panelMain.SetActive(false);
    }
}
