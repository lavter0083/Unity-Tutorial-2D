using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;

    private bool isGround;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");

        Jump();
    }
  
    private void FixedUpdate()
    {

        Move();
    }
    // 움직임 및 도트

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;
        renderers[2].gameObject.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;

        renderers[0].gameObject.SetActive(false);
        renderers[1].gameObject.SetActive(false);
        renderers[2].gameObject.SetActive(true);
    }
    private void Move()
    {
        if (!isGround)
            return;

        if (h != 0) // 움직일때
        {
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);
            renderers[2].gameObject.SetActive(false);

            characterRb.linearVelocityX = h * moveSpeed;

            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else if ( h < 0) 
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
        }
        else if (h == 0) // 움직이지 않을때
        { 
            renderers[0].gameObject.SetActive(true);
            renderers[1].gameObject.SetActive(false);
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
}
    