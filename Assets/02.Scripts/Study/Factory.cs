using UnityEngine;

public class Factory<T> : MonoBehaviour
{
    // 제너릭(Generic) <T>
    // 형식에 의존하지 않고 다양한 타입을 처리할 수 있도록 클래스나 메서드를 정의

    public T prefab;

    public Factory()
    {
        Debug.Log($"Factory는 {typeof(T)} 타입 입니다.");
    }

    // 상속(Inheritance)
    // 부모 클래스의 기능을 자식 클래스가 물려받음

    public class Monster
    {
        public void Move()
        {

        }
    }
    public class Orc : Monster
    {
        public void Smash()
        {
            //Orc는 Monster에게서 Move를 상속 받아 Move와 Smash 기능이 있음
        }
    }

    // 가상화(Virtual)


}
