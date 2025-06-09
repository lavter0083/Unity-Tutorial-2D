using UnityEngine;
using System.Collections;

public class StudyCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("RoutineA");
    }
    IEnumerator RoutineA()
    {
        yield return null;
        Debug.Log("코루틴 실행");
    }
}
