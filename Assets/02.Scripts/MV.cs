using UnityEngine;

public class MV : MonoBehaviour
{
    public int movespeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            transform.position += Vector3.back * movespeed * Time.deltaTime;
        }
    }
}
