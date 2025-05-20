using UnityEngine;
using System;

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start 함수 실행");
        Debug.LogWarning("비상");
        Debug.LogError("초비상");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 함수 실행");
    }
}
