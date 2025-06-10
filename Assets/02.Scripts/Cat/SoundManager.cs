using System.Globalization;
using UnityEngine;

namespace cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource AudioSource;
        public AudioClip JumpClip;
        public AudioClip playBgmClip;
        public AudioClip introBgmClip;
        public AudioClip colliderClip;

        public void SetBGMSound(string bgmName)
        {
            if (bgmName == "Intro")
            {
                AudioSource.clip = introBgmClip;
            }
            else if (bgmName == "Play")
            {
                AudioSource.clip = playBgmClip; // 오디오 소스에 사용될 파일 설정
            }
            AudioSource.loop = true; // 반복 기능
            AudioSource.volume = 0.2f; // 소리
            AudioSource.Play(); // 시작

        }

        public void OnJumpSound()
        {
            AudioSource.PlayOneShot(JumpClip);
        }
        public void OnColliderSound()
        {
            AudioSource.PlayOneShot(colliderClip);
        }
    }
}
