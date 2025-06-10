using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType {Pipe, Apple, Both}
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;

    public float moveSpeed = 2f;
    public float retrunPosX = 15f;
    public float randomPosY;

    private void Start()
    {
        SetRandomSetting(transform.position.x);
        // randomPosY = Random.Range(-8f, -3f);
        // transform.position = new Vector3(transform.position.x, randomPosY, 0);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);

        // 배경 왼쪽으로 이동하는 기능
        if (transform.position.x <= -retrunPosX)
        {
            SetRandomSetting(retrunPosX);
            // randomPosY = Random.Range(-8f, -5f);
            // transform.position = new Vector3(retrunPosX, randomPosY, 0);
        }
    }

    private void SetRandomSetting(float PostX)
    {
        randomPosY = Random.Range(-10f, -5f);
        transform.position = new Vector3(PostX, randomPosY, 0);

        colliderType = (ColliderType)Random.Range(0, 3);

        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.Apple:
                apple.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;
        }
    }
}
