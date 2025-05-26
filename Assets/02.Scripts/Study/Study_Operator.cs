using UnityEngine;

public class Study_Operator : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;

    void Start()
    {;

        string msg = currentLevel >= maxLevel ? "현재 최대레벨 도달" : "현재 최대 레벨이 아님.";

        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
