using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject settingPopup;

    public Button settingButton;
    public Button exitButton;

    void Start()
    {
        settingButton.onClick.AddListener(OnSettingPopup);
        exitButton.onClick.AddListener(OnCloseSettingPopup);
    }

    public void OnSettingPopup()
    {
        settingPopup.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnCloseSettingPopup()
    {
        settingPopup.SetActive(false);
        Time.timeScale = 1f;
    }

}