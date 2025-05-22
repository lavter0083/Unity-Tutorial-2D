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
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * movespeed1 * Time.deltaTime;
    }
}
