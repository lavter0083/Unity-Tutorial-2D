using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D carRb;
    float h;
    float v;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // transform 이동
        // transform.position += Vector3.right * h * movespeed * Time.deltaTime;

    }

    private void FixedUpdate()
    {
        // rigidboy 이동
        carRb.linearVelocityX =  h * movespeed;
        carRb.linearVelocityY = v * movespeed;
        
    }

}