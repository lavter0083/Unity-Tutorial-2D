using System;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 감지된 대상에게 IDamageable이 있다면
        if (other.GetComponent<IDamageable>() != null)
        {
            // 그 대상에게 데미지 10을 주도록 하겠다.
            other.GetComponent<IDamageable>().TakeDamage(10f);
        }
    }
}
