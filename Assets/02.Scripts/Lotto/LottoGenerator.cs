using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class LottoGenerator : MonoBehaviour
{
    public List<int> intList = new List<int>();

    public int shakeCount = 1000;

    private void Awake()
    {
        for (int i = 1; i < 46; i++)
        {
            intList.Add(i);
        }
    }

    IEnumerator Start()
    {
        for (int i = 0; i < shakeCount; i++)
        {
            int ranInt1 = Random.Range(0, intList.Count);
            int ranInt2 = Random.Range(0, intList.Count);

            var temp = intList[ranInt1];
            intList[ranInt1] = intList[ranInt2];
            intList[ranInt2] = temp;

            yield return new WaitForSeconds(0.001f);
        }

        List<int> resultGroup = new List<int>();

        for (int i = 0; i < 6;i++)
            resultGroup.Add(intList[i]);
        resultGroup.Sort();

        string resultNumber = $"이번 주 로또 번호 : {resultGroup[0]} / {resultGroup[1]} / {resultGroup[2]} / {resultGroup[3]} / {resultGroup[4]} / {resultGroup[5]} / 보너스 넘버 : {intList[6]} /";

        Debug.Log(resultNumber);
    }
}
