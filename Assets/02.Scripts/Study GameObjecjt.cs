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

    // ���� ���� �� �̸� ���� ���
    public void CreateAmogus()
    {
        GameObject obj = Instantiate(prefab); //GameObject�� �����ϴ� ���
        obj.name = "gusgus";

        Transform objTf = obj.transform;
        int count = obj.transform.childCount;

        Debug.Log($"ĳ���� �ڽ� ������Ʈ�� �� : {count}");

        Debug.Log($"ĳ���� ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ���� ������ �ڽ� ������Ʈ �̸� : {objTf.GetChild(count - 1).name}");
    }
}
