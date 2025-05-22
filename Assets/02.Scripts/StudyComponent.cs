using UnityEngine; // UnityEngine�̶�� ���ӽ����̽� Ȱ��

public class StudyComponent : MonoBehaviour
//���������� Ŭ������ : ���(����Ƽ�� ������ ����� ����ִ°�)
{
    public GameObject obj;
    public Transform objTf;
//���������� Ÿ�� ������

    // public string ChangeName;
//���������� Ÿ�� ������

    void Start()
//  Ÿ�� �Լ���
    {
        // obj = GameObject.Find("Main Camera");

        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");
        
        objTf.gameObject.SetActive(false);


        objTf = GameObject.FindGameObjectWithTag("Player").transform;

        //objTf = GameObject.FindGameObjectWithTag("Player").GetComponent<transform>;

        Debug.Log(obj.name);
        Debug.Log(obj.tag);
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);

        Debug.Log(obj.GetComponent<MeshFilter>().mesh);
        Debug.Log(obj.GetComponent<MeshRenderer>().material);
        Debug.Log(obj.GetComponent<BoxCollider>().size);

        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj ��Ȱ��ȭ
        obj.SetActive(false);
    }

}
