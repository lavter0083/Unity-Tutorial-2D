using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteControlor : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    public VideoClip[] clips; // 영상 파일 배열

    private VideoPlayer videoPlayer;

    public int currClipIndex = 0; // 현재 영상 index

    public bool isOn = false;
    public bool isMute = false;


    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0]; // Default 영상 설정
    }

    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {
        if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true;
        }
        else // isOn == true
        {
            videoScreen.SetActive(false);
            isOn = false;
        }
        
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoScreen.GetComponent<VideoPlayer>().SetDirectAudioMute(0, isMute);
    }

    public void OnNextChannel()
    {
        currClipIndex++;
        if (currClipIndex > 3)
        {
            currClipIndex = 0;
        }

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
    public void OnPrevChannel()
    {
        currClipIndex--;
        if (currClipIndex < 0)
        {
            currClipIndex = 3;
        }

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
}
