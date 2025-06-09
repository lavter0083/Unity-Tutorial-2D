using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] {"철수","영희","실패","성공","마이클"};
    public string finadName;

    void Start()
    {
        FindPerson(finadName);
    }
    private void FindPerson(string name)
    {
        bool isFind = false;
        foreach (string person in persons)
        {
            if (person == name)
            {
                isFind = true;
                Debug.Log($"{name}를 찾았습니다.");
            }
        }
        if (isFind)
            Debug.Log($"{name}를 찾지 못했습니다.");
    }

}
