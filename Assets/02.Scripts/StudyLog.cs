using UnityEngine;
using System;

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start �Լ� ����");
        Debug.LogWarning("���");
        Debug.LogError("�ʺ��");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update �Լ� ����");
    }
}
