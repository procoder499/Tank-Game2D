using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Button btnReplay;
    public Button btnSelectlevel;
    public Button btnResume;

    public GameObject panelSelectlevel;
    public GameObject panelPause;
    public GameObject panelGameplay;
    // Start is called before the first frame update
    void Start()
    {
        btnReplay.onClick.AddListener(RestartGame);
        btnSelectlevel.onClick.AddListener(SelectlevelButtonClicked);
        btnResume.onClick.AddListener(ResumeButtonClicked);
    }
    public void RestartGame()
    {
        // Lấy tên của scene hiện tại
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Tải lại scene hiện tại
        SceneManager.LoadScene(currentSceneName);
    }
    private void SelectlevelButtonClicked()
    {
        panelGameplay.SetActive(false);
        panelPause.SetActive(false);
        panelSelectlevel.SetActive(true);
    }
    private void ResumeButtonClicked()
    {
        panelPause.SetActive(false);
    }
}
