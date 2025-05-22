using System.Threading;
using UnityEngine;

public class StudyGameObjecjt : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos;
    public Quaternion rot;


    void Start()
    {
        CreateAmogus();

    }

    // 어몽어스 생성 및 이름 변경 기능
    public void CreateAmogus()
    {
        GameObject obj = Instantiate(prefab); //GameObject를 생성하는 기능
        obj.name = "gusgus";

        Transform objTf = obj.transform;
        int count = obj.transform.childCount;

        Debug.Log($"캐릭터 자식 오브젝트의 수 : {count}");

        Debug.Log($"캐릭터 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터 마지막 자식 오브젝트 이름 : {objTf.GetChild(count - 1).name}");
    }
}
