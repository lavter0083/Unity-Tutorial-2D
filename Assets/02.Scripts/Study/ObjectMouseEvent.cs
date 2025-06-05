using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }
    void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }
    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
    }
    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
    }   
}
