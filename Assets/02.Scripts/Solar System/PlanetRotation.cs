using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlant;

    public float rotSpeed = 30f; // �����ӵ�

    public float revolutionSpeed = 100f; //���� �ӵ�

    public bool isRevolution = false;

    void Update()
    {

        // �ڱ� �ڽ��� ȸ���ϴ� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        
        if (isRevolution == true)
        {
            // �����ϴ� ���
            transform.RotateAround(targetPlant.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }

    }
}
