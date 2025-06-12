using Unity.VisualScripting;
using UnityEngine;
using cat;
using System.Collections;

public class Catcontroller : MonoBehaviour
{
    public VideoManager videoManager;

    public SoundManager SoundManager;
    private Rigidbody2D CatRb;
    private Animator CatAnim;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public float jumpPower = 30f;
    public float limitPower = 25f;
    public bool isGround = false;
    public int jumpCount = 0;

    void Start() // 1번만 실행
    {
        CatRb = GetComponent<Rigidbody2D>();
        CatAnim = GetComponent<Animator>();
    }


    private void OnEnable() // 켜질때마다 1번씩 실행
    {
        transform.localPosition = new Vector3(-8f, -2.82f, 0f); // 고양이 처음 위치
        GetComponent<CircleCollider2D>().enabled = true;
        SoundManager.AudioSource.mute = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 8)
        {
            CatAnim.SetTrigger("Jump"); // 점프 애니메이션 
            CatAnim.SetBool("IsGround 0", false);
            CatRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++; //1씩 증가
            SoundManager.OnJumpSound();

            if (CatRb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
                CatRb.linearVelocityY = limitPower;
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = CatRb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if(GameManager.score == 10)
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white, true); 
                this.GetComponent<CircleCollider2D>().enabled = false;

                //Invoke("HappyVideo", 3f);
                StartCoroutine(EndingRout(true));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            CatAnim.SetBool("IsGround 0", true);
            jumpCount = 0;
            isGround = true;
        }

        if (other.gameObject.CompareTag("Pipe"))
        {
            SoundManager.OnColliderSound();

            gameOverUI.SetActive(true);
            fadeUI.SetActive(true);
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black, true);
            this.GetComponent<CircleCollider2D>().enabled = false;

            //Invoke("SadVideo", 3f);
            StartCoroutine(EndingRout(false));
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    IEnumerator EndingRout(bool isHappy)
    {
        yield return new WaitForSeconds(2f);
        transform.parent.gameObject.SetActive(false); //Play 오브젝트 off

        videoManager.VideoPlay(isHappy);
        yield return new WaitForSeconds(1f);

        var newColor = isHappy ? Color. white: Color.black;
        fadeUI.GetComponent<FadeRoutine>().OnFade(3f, newColor, false);

        //yield return new WaitUntil(() => videoManager.vPlayer.isPlaying);

        yield return new WaitForSeconds(1f);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        SoundManager.AudioSource.mute = true;
    }

}
