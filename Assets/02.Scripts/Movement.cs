using UnityEngine;

public class Movement : MonoBehaviour
{
    private float movespeed;
    public float movespeed1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * movespeed;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * movespeed1 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * movespeed1 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movespeed1 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right  * movespeed1 * Time.deltaTime;
        }
    }
}
