using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // 월드 방향으로 이동
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 월드 방향을 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // 월드 방향으로 회전
        transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        // 로컬 방향으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 월드 방향으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 특정 위치의 주변을 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);

        // 특정 위치를 바라보며 회전
        transform.LookAt(Vector3.zero);
    }
}