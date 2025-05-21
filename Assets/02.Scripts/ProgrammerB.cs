using DevA;
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA PA;

    private void Start()
    {
        //PA.num1 = 20;
        PA.num2 = 34;
        //PA.num3 = 13;
        //PA.num4 = 576;
        //PA.num5 = 10;
        Debug.Log($"PA.num {PA.num2}");
    }

}
