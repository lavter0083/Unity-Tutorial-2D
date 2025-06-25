using UnityEngine;
using UnityEngine.UI;

public class KnightControllerJoyStick : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    [SerializeField] private Button jumpButton;
    [SerializeField] private Button atkButton;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 13f;

    private float atkDamage = 3f;

    private bool isGround;
    private bool isCombo;
    private bool isAttack;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();


        jumpButton.onClick.AddListener(Jump); // 점프 버튼 누르면 해당 기능 실행
        atkButton.onClick.AddListener(Attack);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}만큼 공격");
        }
    }

    public void InputJoyStick(float x, float y) // 매개변수 활용하여 inputDir에 벡터 좌표를 넣음
    {
        inputDir = new Vector3(x, y, 0).normalized;
        animator.SetFloat("JoyStickX", inputDir.x);
        animator.SetFloat("JoyStickY", inputDir.y);

        if (inputDir.x != 0)
        {
            var scalX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scalX, 1, 1);
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
        if (isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void Attack()
    {
        // isAttack이 true인지 // isAttack은 생성될때 false 상태임
        // 즉 !들어가면 생성될때의 반대값인지 확인하는것
        if (!isAttack)
        {
            isAttack = true;
            atkDamage = 3f;
            animator.SetTrigger("Attack");
        }
        else
        {
            isCombo = true;
            Debug.Log("콤보확인");
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
            animator.SetBool("isCombo",false);
        }
    }

    public void EndCombo()
    {
        isAttack=false;
        isCombo=false;
        animator.SetBool("isCombo", false);
    }
}

