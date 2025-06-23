using UnityEngine;

public class KnightControllerJoyStick : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private bool isGround;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 13f;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    private void Update() // 바로바로 실행해야하는 일반적인 작업은 update로
    {
        
    }

    void FixedUpdate() // 물리적인 작업은 fixedupdate에서 실행해야 좋음
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    private void Move()
    {
        if (inputDir.x != 0)
        {
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void SetAnim()
    {
        if (inputDir.x != 0)
        {
            var scalX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scalX, 1, 1);
            animator.SetBool("isRun", true);
        }
        else if (inputDir.x == 0)
        {
            animator.SetBool("isRun", false);
        }

    }
}

