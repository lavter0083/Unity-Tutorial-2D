using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalcultaionType { Plus, Minus, Multiply, Divide} //  열거형 생성
    public CalcultaionType calcultaionType;

    public int inputValue1, inputValue2, result;

    void Start()
    {
        Debug.Log($"계산 결과 : {Calculation()}");
    }

    private int Calculation()
    {
        switch (calcultaionType)
        {
            case CalcultaionType.Plus:
            result = inputValue1 + inputValue2;
                break;
            case CalcultaionType.Minus:
            result = inputValue1 - inputValue2;
                break;
            case CalcultaionType.Multiply:
            result = inputValue1 * inputValue2;
                break;
            case CalcultaionType.Divide:
            result = inputValue1 / inputValue2;
                break;
        }

        return result;
    }
}
