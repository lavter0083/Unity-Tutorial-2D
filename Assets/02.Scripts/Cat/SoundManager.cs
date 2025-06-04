using UnityEngine;

namespace cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource AudioSource;
        public AudioClip JumpClip;
        public AudioClip BgmClip;

        private void Start()
        {
            SetBGMSound();
        }

        public void SetBGMSound()
        {
            AudioSource.clip = BgmClip; // 오디오 소스에 사용될 파일 설정
            AudioSource.playOnAwake = true; // 시작할때 자동 실행
            AudioSource.loop = true; // 반복 기능
            AudioSource.volume = 0.2f; // 소리

            AudioSource.Play(); // 시작

            //AudioSource.Stop(); // 정지
            //AudioSource.Pause(); // 일시정지
        }

        public void OnJumpSound()
        {
            AudioSource.PlayOneShot(JumpClip);
        }
    }
}
