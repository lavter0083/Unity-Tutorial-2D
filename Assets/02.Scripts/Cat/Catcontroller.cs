using Unity.VisualScripting;
using UnityEngine;
using cat;

public class Catcontroller : MonoBehaviour
{
    public SoundManager SoundManager;
    private Rigidbody2D CatRb;
    private Animator CatAnim;

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
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
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
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            CatAnim.SetBool("IsGround 0", true);
            jumpCount = 0;
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
