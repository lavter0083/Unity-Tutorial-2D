using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    private int num1 = 10;
    public int Num1
    {
        get { return num1; }
        set { num1 = value; }
    }

    public int Num2 { get; set; } = 99;

    public int Num3 { get; private set; } = 30;

    private float hp = 1f;
}
