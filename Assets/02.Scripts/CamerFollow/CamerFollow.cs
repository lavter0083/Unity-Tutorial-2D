using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothSpeed = 5f;

    [SerializeField] private Vector2 minBound;
    [SerializeField] private Vector2 maxBound;


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 destination = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, destination, smoothSpeed * Time.deltaTime);
        //                             현재위치             타겟위치        비율
        
        smoothPos.x = Mathf.Clamp(smoothPos.x, minBound.x, maxBound.x);
        smoothPos.y = Mathf.Clamp(smoothPos.y, minBound.y, maxBound.y);
        //                        값           최소값      최대값

        transform.position = smoothPos;
    }
}
