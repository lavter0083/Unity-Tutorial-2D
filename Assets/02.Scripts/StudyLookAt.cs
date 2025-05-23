using System.Threading;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTF;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos; // �߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start() // 1�� ���� -> �����ΰ��� �����ϴ� ���
    {
        targetTF = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() // ���𰡸� �ٶ󺸴� ���
    {
        turretHead.LookAt(targetTF);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
