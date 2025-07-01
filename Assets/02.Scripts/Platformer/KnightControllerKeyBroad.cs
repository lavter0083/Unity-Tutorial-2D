using SimpleInputNamespace;
using UnityEngine;

public class KnightControllerKeyBroad : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 13f;

    private float atkDamage = 3f;

    private bool isGround;
    private bool isCombo;
    private bool isAttack;
    private bool isLadder;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    private void Update() // 바로바로 실행해야하는 일반적인 작업은 update로
    {
        InputKeyboard();
        Jump();
        Attack();
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}만큼 공격");
        }

        if (other.CompareTag("Ladder"))
        {
            isLadder = true;
            knightRb.gravityScale = 0;
            knightRb.linearVelocity = Vector2.zero;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isLadder = false;
            knightRb.gravityScale = 3;
            knightRb.linearVelocity = Vector2.zero;
        }
    }

    void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        animator.SetFloat("JoyStickX", inputDir.x);
        animator.SetFloat("JoyStickY", inputDir.y);

        if (inputDir.y < 0)
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 0.3f);
        }
        else
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 1.7f);
        }
    }

    private void Move()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }

        if (isLadder && inputDir.y != 0)
        {
            knightRb.linearVelocityY = inputDir.y * moveSpeed;
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


    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // isAttack이 true인지 // isAttack은 생성될때 false 상태임
            // 즉 !들어가면 생성될때의 반대값인지 확인하는것
            if (!isAttack)
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("isAttack");
            }
            else
            {
                isCombo = true;
                Debug.Log("콤보확인");
            }
        }

    }

    public void CheckCombo()
    {
        if (isCombo)
        {
            atkDamage = 5f;
            Debug.Log("콤보실행");
            animator.SetBool("isCombo", true);
        }
        else
        {
            isAttack = false;
            animator.SetBool("isCombo", false);
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
        animator.SetBool("isCombo", false);
    }
}
