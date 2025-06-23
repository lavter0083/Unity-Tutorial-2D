using UnityEngine;

public class MathCross : MonoBehaviour
{
    public Vector3 vecA = new Vector3(1, 0, 0);
    public Vector3 vecB = new Vector3(0, 1, 0);

    void Start()
    {
        Vector3 result = Vector3.Cross(vecA, vecB);
        var result2 = Vector3.Cross(vecA, vecB).magnitude;

        Debug.Log($"벡터의 외적 : {result}");
        Debug.Log($"벡터의 외적 : {result2}");

        Vector3 result3 = Vector3.Reflect(vecA, vecB);
        //                        Reflect(입사각, 번선벡터)

    }
}
