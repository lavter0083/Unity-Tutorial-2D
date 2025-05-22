using UnityEngine; // UnityEngine이라는 네임스페이스 활용

public class StudyComponent : MonoBehaviour
//접근제한자 클래스명 : 상속(유니티의 유용한 기능이 들어있는곳)
{
    public GameObject obj;
    public Transform objTf;
//접근제한자 타입 변수명

    // public string ChangeName;
//접근제한자 타입 변수명

    void Start()
//  타입 함수명
    {
        // obj = GameObject.Find("Main Camera");

        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
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

        // obj 비활성화
        obj.SetActive(false);
    }

}
