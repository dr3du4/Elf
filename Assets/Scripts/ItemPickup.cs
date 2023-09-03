using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

   public  void Pickup()
    {
        InventorManager.instance.Add(item);
        
    }
}
