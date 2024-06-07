using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelGamePlay : MonoBehaviour
{
    public Button btnPause;
    public Button btnSelectWeapon;

    public GameObject panelSelectWeapon;
    public GameObject panelPause;
    // Start is called before the first frame update
    void Start()
    {
        btnPause.onClick.AddListener(OnPauseButtonClicked);
        btnSelectWeapon.onClick.AddListener(OnSelectButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnPauseButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelPause.SetActive(true);
    }
    private void OnSelectButtonClicked()
    {
        // Hiển thị panelLevels và ẩn panelMain
        panelSelectWeapon.SetActive(true);
    }
}
