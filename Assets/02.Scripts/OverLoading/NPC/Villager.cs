using UnityEngine;

public class Villager : MonoBehaviour, IMove, ITalk
{
    public float hp;
    public float speed;

    public void Move()
    {
        Debug.Log("Moove");
        transform.position = transform.right * speed * Time.deltaTime;
    }

    public void Talk()
    {
        Debug.Log("Talk");
    }

    void Update()
    {
        Move();
    }
}
