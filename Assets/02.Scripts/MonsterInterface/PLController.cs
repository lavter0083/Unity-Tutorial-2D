using System.Collections;
using UnityEngine;

public class PLController : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private GameObject hitBox;
    [SerializeField] private float moveSpeed = 3.0f;
    private float h, v;

    private bool isAttack = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (h == 0 && v == 0) // Idle 상태 
        {
            animator.SetBool("Run", false);
        }
        else // Run 상태
        {
            if (h > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (h < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

                animator.SetBool("Run", true);

            var dir = new Vector3(h, v, 0).normalized;
            transform.position += dir * moveSpeed * Time.deltaTime;
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isAttack)
        {
            StartCoroutine(AttackRoutine());
        }
    }

    IEnumerator AttackRoutine()
    {
        isAttack = true;
        hitBox.SetActive(true);

        yield return new WaitForSeconds(0.25f);
        hitBox.SetActive(false);
        isAttack = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Mooonster>() != null)
        {
            Mooonster monster = other.GetComponent<Mooonster>();
            // monster 변수에게 Hit을 실행
            StartCoroutine(monster.Hit(1));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<IItem>() != null)
        {
            IItem item = other.gameObject.GetComponent<IItem>();
            item.Get();
        }
    }
}
