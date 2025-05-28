using UnityEngine;

public class TransformLoopmap : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float retrunPosX = 15f;
    public float randomPosY;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);
            
        // 배경 왼쪽으로 이동하는 기능
        if (transform.position.x <= -retrunPosX)
        {
            randomPosY = Random.Range(-9f, -5f);
            transform.position = new Vector3(retrunPosX, randomPosY, 0);
        }
    }
}
