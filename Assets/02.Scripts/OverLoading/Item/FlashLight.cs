using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    // public GameObject lightObj;
    // public bool isLight;

    public void Grab()
    {
        Debug.Log("Grab the FlashLight");
    }

    public void Use()
    {
        // cisLight = !isLight;
        // lightObj.SetActive(isLight);

        Debug.Log("Light on");
    }

    public void Drop()
    {
        Debug.Log("Drop the FlashLight");
    }
}
