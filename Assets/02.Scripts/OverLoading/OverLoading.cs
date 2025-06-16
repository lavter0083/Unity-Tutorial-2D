using UnityEngine;

// Player 코드
public class OverLoading : MonoBehaviour
{
    void Start()
    {
        Attack();
        Attack(true);
        Attack(10f);

        GameObject monsterObj = new GameObject("몬스터");
        Attack(10f, monsterObj);
    }

    public void Attack()
    {
        Debug.Log("공격");
    }

    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("마법 공격");
    }

    public void Attack(float damage)
    {
        Debug.Log($"{damage} 데미지 만큼 공격");
    }

    public void Attack(float damage, GameObject target)
    {
        Debug.Log($"{target.name}에게 {damage} 데미지 만큼 피해를 입힘");
    }
}
