using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public bool isActive = false;

    public GameObject window;
    public InventorManager inventory;
    
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isActive)
        {
            Debug.Log("ZAMKNIECIE");
            isActive = false;
            window.SetActive(false);
            
        }       
        else if (Input.GetKeyDown(KeyCode.I) && isActive==false)
        {
            inventory.ListItems();
            Debug.Log("OTWARCIE");
            isActive = true;
            window.SetActive(true);
        }       
    }
}
