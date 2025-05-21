using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using NUnit.Framework;
using UnityEngine;


public class StudyArray : MonoBehaviour
{
    int num1 = 1;
    private int num2 = 2;
    public int num3 = 3;

    [SerializeField]
    private int num4 = 4;
    [SerializeField] int num5 = 5;


    List<int> listNumber = new List<int>();

    private int[] ArrayNumber = new int[5] { 1, 2, 3, 4, 5 };
    void Start()
    {
        
        listNumber.Add(0);
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        
        Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}");

        Debug.Log($"���� List�� ������ ������ {listNumber[listNumber.Count - 1 ]}");

        Debug.Log($"Array ù��° �� : {ArrayNumber[0]}");
        Debug.Log($"Array ����° �� : {ArrayNumber[2]}");
    }

}
