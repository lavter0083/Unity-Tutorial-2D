using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();

    public void AddItem(IItem item)
    {
        items.Add(item.Obj);
    }

}
