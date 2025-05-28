using Unity.VisualScripting;
using UnityEngine;

public class Catcontroller : MonoBehaviour
{
    private Rigidbody2D CatRb;
    public float jumpPower;
    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        CatRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            CatRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++; //1¾¿ Áõ°¡
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
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
