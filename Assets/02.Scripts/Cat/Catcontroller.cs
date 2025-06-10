using Unity.VisualScripting;
using UnityEngine;
using cat;

public class Catcontroller : MonoBehaviour
{
    public SoundManager SoundManager;
    private Rigidbody2D CatRb;
    private Animator CatAnim;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happyVideo;
    public GameObject sadVideo;

    public float jumpPower = 30f;
    public float limitPower = 25f;
    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        CatRb = GetComponent<Rigidbody2D>();
        CatAnim = GetComponent<Animator>();
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
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white); 
                this.GetComponent<CircleCollider2D>().enabled = false;

                Invoke("HappyVideo", 5f);
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
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black);
            this.GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 5f);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    private void HappyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        SoundManager.AudioSource.mute = true;
    }
}
