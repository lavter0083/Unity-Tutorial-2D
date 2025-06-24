using UnityEngine;
using UnityEngine.EventSystems;

public class JouStick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private KnightControllerJoyStick knightControllerJoyStick;

    [SerializeField]private GameObject backgroundUI;
    [SerializeField]private GameObject handlerUI;

    private Vector2 startPos, currPos;

    void Start()
    {
        backgroundUI.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData) // 패널을 누를때
    {
        backgroundUI.SetActive(true);
        backgroundUI.transform.position = eventData.position; // 마우스 포인터 위치
        startPos = eventData.position;
        Debug.Log("Pointer Down");
    }

    public void OnDrag(PointerEventData eventData) // 패널 안에서 드래그 할 때
    {
        currPos = eventData.position;
        Vector2 dragDir= currPos - startPos;

        float maxDist = Mathf.Min(dragDir.magnitude, 100f); // 드래그 값
        handlerUI.transform.position = startPos + dragDir.normalized * maxDist; // 마우스 포인터 위치
        
        knightControllerJoyStick.InputJoyStick(dragDir.x, dragDir.y);

        Debug.Log("On Drag");
    }

    public void OnPointerUp(PointerEventData eventData) // 패널을 누르고 뗄 때
    {
        knightControllerJoyStick.InputJoyStick(0,0);
        handlerUI.transform.localPosition = Vector2.zero;
        backgroundUI.SetActive(false);
        Debug.Log("Pointer Up");
    }




}
