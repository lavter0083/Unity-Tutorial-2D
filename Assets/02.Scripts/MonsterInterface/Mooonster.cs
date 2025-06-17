using UnityEngine;

public abstract class Mooonster : MonoBehaviour
{
    public SpriteRenderer sRenderer;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    public int dir = 1;

    public abstract void Init();

    private void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Hit(1);
    }

    private void Update()
    {
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

    void Hit(float damage)
    {
        hp -= damage;

        if (hp == 0)
        {
            Debug.Log("¸ó½ºÅÍ Á×À½");
            Destroy(gameObject);
        }
    }
}
