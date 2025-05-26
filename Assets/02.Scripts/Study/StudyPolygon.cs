using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh(); // 형태 데이터가 들어갈 Mesh 타입의 변수 생성

        Vector3[] vectices = new Vector3[] // 점 4개 찍기
        {
            new Vector3 (0, 0, 0),
            new Vector3 (1, 0, 0),
            new Vector3 (0, 1, 0),
            new Vector3 (1, 1, 0)
        };

        int[] triangles = new int[]
        {
            0, 2, 1,
            2, 3, 1
        };
    }

}
