using UnityEditor;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float RotSpeed;
    public bool isStop;

    private void Start()
    {
        RotSpeed = 0f;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * RotSpeed);
        transform.Rotate(0f, 0f, RotSpeed);
        if (Input.GetMouseButtonDown(0))
        {
            RotSpeed = 2f;
        }  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        if (isStop == true)
        {
            RotSpeed *= 0.98f;

            if (RotSpeed < 0.01f)
            {
                RotSpeed = 0f;
                isStop = false;
            }
        }

    }
}
