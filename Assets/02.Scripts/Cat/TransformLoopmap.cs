using UnityEngine;

public class TransformLoopmap : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Vector3 returnPos = new Vector3 (0f, 1.5f, 0f);

    public float movePos;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);
            
        // 배경 왼쪽으로 이동하는 기능
        if (transform.position.x <= -movePos)
        {
            transform.position = returnPos;
        }
    }
}
