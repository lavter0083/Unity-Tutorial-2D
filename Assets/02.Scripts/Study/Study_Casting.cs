using System;
using UnityEngine;

public class Study_Casting : MonoBehaviour
{
    int number1 = 1;
    float number2 = 10.3f;

    private void Start()
    {
        // number1 = (int)number2; // 소수점 없애기
        float number4 = Mathf.Floor(number2); //내림차순
        float number5 = Mathf.Ceil(number2); // 올림차순
        float number6 = Mathf.Round(number2); // 반올림 x>=5 ? 올림 : 내림 (5 기준으로 올림)

        Debug.Log(number1);

        Debug.Log($"Floor 내림차순 : {number4}");
        Debug.Log($"Ceil 올림차순 : {number5}");
        Debug.Log($"Round 반올림 : {number6}");

        // string 타입 선언 후 숫자형으로 변환
        string str1 = "123";
        string str2 = "456";
        Debug.Log("String : " + str1 + str2);

        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);
        Debug.Log("Int : " + num1 + num2);
        Debug.Log("Int : " + (num1 + num2));
        Debug.Log($"Int : + {num1} + {num2}");

        // int를 string 값으로(문자열 변환)
        int nuum0 = 123;

        string str3 = nuum0.ToString(); // "123"

        // int 타입 bool로

        int nuum1 = 0;
        int nuum2 = 1;
        int nuum3 = 2;
        int nuum100 = 100;

        Debug.Log("Num1 : " + Convert.ToBoolean(nuum1));
        Debug.Log("Num2 : " + Convert.ToBoolean(nuum2));
        Debug.Log("Num3 : " + Convert.ToBoolean(nuum3));
        Debug.Log("Num100 : " + Convert.ToBoolean(nuum100));
        // int타입은 0만 false 나머진 전부 true

        // float 타입 bool로

        float fNum0 = 0f;
        float fNum1 = 1.57f;
        float fNum2 = 3.14f;

        Debug.Log("fNum0 : " + Convert.ToBoolean(fNum0)); // 0.0f (false)
        Debug.Log("fNum1 : " + Convert.ToBoolean(fNum1)); // 1.57f (true)
        Debug.Log("fNum2 : " + Convert.ToBoolean(fNum2)); // 3.14f (true)

        // string 타입 bool로

        string str4 = "true";
        string str5 = "false";
        string str6 = "안녕하세요";

        Debug.Log("str4 : " + Convert.ToBoolean(str4)); // true
        Debug.Log("str5 : " + Convert.ToBoolean(str5)); // fasle
        Debug.Log("str6 : " + Convert.ToBoolean(str6)); // 에러

        // bool 타입 int 타입으로
        void Start()
        {
            bool isBool1 = true;
            bool isBool2 = false;

            int num1 = Convert.ToInt32(isBool1);
            int num2 = Convert.ToInt32(isBool2);

            Debug.Log(num1);
            Debug.Log(num2);
        }
    }
}
