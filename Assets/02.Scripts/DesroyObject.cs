using UnityEngine;

public class DesroyObject : MonoBehaviour
{
    public float DestroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, DestroyTime);

    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı� �ƽ��ϴ�.");
        
    }
}
