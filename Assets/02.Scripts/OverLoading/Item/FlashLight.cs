using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;
    // public bool isLight;

    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        Debug.Log("Grab the FlashLight");
    }

    public void Use()
    {
        lightObj.SetActive(!lightObj.activeSelf);
        Debug.Log("Light on");
    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.position = Vector3.zero;
        Debug.Log("Drop the FlashLight");
    }
}
