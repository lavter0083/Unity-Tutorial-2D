using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj;

    public string ChangeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = ChangeName;
    }

}
