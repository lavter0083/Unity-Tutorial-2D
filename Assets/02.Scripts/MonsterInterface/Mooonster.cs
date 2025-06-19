using System.Collections;
using UnityEngine;

public abstract class Mooonster : MonoBehaviour
{
    public SpawnManager spawner;

    public SpriteRenderer sRenderer;
    private Animator animator;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    public int dir = 1;
    private bool ismove;
    private bool isHit = false;

    public abstract void Init();

    private void Start()
    {
        spawner = FindAnyObjectByType<SpawnManager>();  

        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(Hit(1));
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!ismove)
            return;

        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }   
        else if (transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        } 
        
    }

    public IEnumerator Hit(float damage)
    {
        if (isHit)
            yield break;

        isHit = true;
        ismove = false;
        animator.SetTrigger("Hit");

        hp -= damage;
        // Á×¾úÀ»¶§
        if (hp <= 0)
        {
            animator.SetTrigger("Death");
            spawner.DropCoin(transform.position);

            yield return new WaitForSeconds(2.0f);
            gameObject.SetActive(false);

            yield break;
        }

        yield return new WaitForSeconds(0.7f);
        ismove = true;
        isHit = false;

    }
}
