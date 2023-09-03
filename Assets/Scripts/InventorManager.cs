using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorManager : MonoBehaviour
{
    public static InventorManager instance;
    public List<Item> Items = new List<Item>();

    private void Awake()
    {
        instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }
}
