using UnityEngine;
using System.Collections.Generic;

public class Charter : MonoBehaviour
{
    public IDropItem currentItem;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentItem.Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 감지된 대상이 IDropItem이 있다면
        if (other.GetComponent<IDropItem>() != null)
        {
            IDropItem item = other.GetComponent<IDropItem>();

            item.Grab();

            currentItem = item;
        }
    }
}
