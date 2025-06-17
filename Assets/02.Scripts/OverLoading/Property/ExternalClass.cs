using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    public StudyProperty studyProperty;

    private void Start()
    {
        int number1 = studyProperty.Num1; // private 필드에 접근
        studyProperty.Num1 = 100; 

        // int number2 = studyProperty.num2; // public 필드에 접근

    }
}
