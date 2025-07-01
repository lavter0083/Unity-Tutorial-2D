using UnityEngine;

public class Goblin : MonsterCore
{
    void Start()
    {
        //Init(10f, 3f);
    }

    //protected override void Init(float hp, float speed)
    //{
        //base.Init(hp, speed);   
    //}

    public override void Idle()
    {
        Debug.Log("Idle");
    }

    public override void Patrol()
    {
        Debug.Log("Patrol");

    }

    public override void Trace()
    {
        Debug.Log("Trace");

    }

    public override void Attack()
    {
        Debug.Log("Attack");
    }
}
