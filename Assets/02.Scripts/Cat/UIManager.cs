using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace cat.ui
{
    public class UIManager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        private void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputField.text == "";

            if (isNoText)
            {
                Debug.Log("입력한 텍스트 없음");
            }
            else
            {
                playObj.SetActive(true);
                introUI.SetActive(false);

                Debug.Log($"{nameTextUI} 입력");
                nameTextUI.text = inputField.text;
                nameTextUI.text = inputField.text;
            }
        }
    }

}
