using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D playerRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;

    private float atkDamage;

    private bool isGround;
    private bool isAttack;
    private bool isCombo;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update() // 바로바로 실행해야하는 일반적인 작업은 update로
    {
        InputKeyboard();
        Jump();
        Attack();
    }

    private void FixedUpdate() // 물리적인 작업은 fixedupdate에서 실행해야 좋음(rigidbody)
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other) // Ground 태그를 가진 오브젝트에 충돌시 isGround true으로 변함
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) // Ground 태그를 가진 오브젝트에서 떨어지면 isGround false 변함
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}만큼 공격");
        }
    }

    private void InputKeyboard() // 움직임 조작 적용
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        animator.SetFloat("JoyStickX", inputDir.x); // Blind Tree에 애니메이션 연결
        animator.SetFloat("JoyStickY", inputDir.y);
    }

    private void Move() // 움직이는 속도 및 좌우 대칭 적용
    {
        if (inputDir.x != 0)
        {
            var scalX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scalX, 1, 1);

            playerRb.linearVelocityX = inputDir.x * moveSpeed;
        }
    }

    void Jump() //점프 기능 및 애니메이션 활성화
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)//isGround 태그 가진 오브젝트 충돌시 점프 기능 다시 활성화
        {
            animator.SetTrigger("isJump");
            playerRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
    
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(!isAttack)
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("isAttack");
            }
            else
            {
                isCombo = true;
            }
        }
    }

    public void CheckCombo()
    {
        if (isCombo)
        {
            atkDamage = 5f;
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
