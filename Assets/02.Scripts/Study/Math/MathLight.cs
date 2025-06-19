using System;
using UnityEngine;

public class MathLight : MonoBehaviour
{
    private Light light;
    private float theta;
    [SerializeField] private float power;
    [SerializeField] private float speed;


    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        theta += Time.deltaTime * speed;

        light.intensity = Mathf.Sin(theta) * power; // 삼각함수 그래프

        // 유명한 노이즈
    }
}
