using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        playTimeUI.text = string.Format("플레이 시간 : {0:F1}초", timer);
    }
}
