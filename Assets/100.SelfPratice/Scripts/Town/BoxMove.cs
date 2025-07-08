using UnityEngine;

public class BoxMove : MonoBehaviour
{
    private Rigidbody2D boxMoveRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        boxMoveRb = GetComponent<Rigidbody2D>();
    }

    private void Update() // 바로바로 실행해야 하는 일반적인 작업은 Update
    {
        InputKeyborad();
    }

    private void FixedUpdate() // 물리적 작업은 fiexdupdate에서
    {
        Move();
    }

    private void InputKeyborad() // 움직임 적용
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        inputDir = new Vector3(h, v, 0);
    }

    private void Move()
    {
        boxMoveRb.linearVelocity = inputDir * moveSpeed;
    }
}
