using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    [SerializeField] private AudioSource bgmAudio;
    [SerializeField] private AudioSource eventAudio;

    [SerializeField] private AudioClip[] clips;

    [SerializeField] private Slider bgmVolume;
    [SerializeField] private Toggle bgmMute;

    [SerializeField] private Slider eventVolume;
    [SerializeField] private Toggle eventMute;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        bgmVolume.value = bgmAudio.volume;
        eventVolume.value = eventAudio.volume;

        bgmMute.isOn = bgmAudio.mute;
        eventMute.isOn = eventAudio.mute;
    }

    private void Start()
    {
        BgmSoundPlay("Town BGM");

        bgmVolume.onValueChanged.AddListener(OnBGMVolumeChange);
        eventVolume.onValueChanged.AddListener(OnEventVolumeChange);

        bgmMute.onValueChanged.AddListener(OnBGMMuteToggled);
        eventMute.onValueChanged.AddListener(OnEventMuteToggled);

    }

    public void BgmSoundPlay(string clipName)
    { 
        // 사운드 클립을 찾아서 Audio 적용
        foreach (var clip in clips)
        {
            if (clip.name == clipName)
            {
                bgmAudio.clip = clip;
                bgmAudio.Play();
                return;
            }
        }
        Debug.Log($"{clipName}을 찾지 못했습니다.");
    }

    public void EventSoundPlay(string clipName)
    {
        foreach (var clip in clips)
        {
            if (clip.name == clipName)
            {
                eventAudio.PlayOneShot(clip);

                return;
            }
        }

        Debug.Log($"{clipName}을 찾지 못했습니다.");
    }

    private void OnBGMVolumeChange(float volume)
    {
        bgmAudio.volume = volume;
    }

    private void OnEventVolumeChange(float volume)
    {
        eventAudio.volume = volume;
    }

    private void OnBGMMuteToggled(bool isMute)
    {
       bgmAudio.mute = isMute;
    }

    private void OnEventMuteToggled(bool isMute)
    {
        eventAudio.mute = isMute;
    }
}
