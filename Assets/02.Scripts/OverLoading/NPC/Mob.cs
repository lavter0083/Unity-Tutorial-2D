using System.Xml.Linq;
using UnityEngine;

public abstract class Mob : Charter, IDamageable
{
    public float hp;

    public abstract void SetHealth();

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("몬스터 다운");
    }
}