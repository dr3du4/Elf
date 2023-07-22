using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketGreen : MonoBehaviour
{
   
    public GameObject player;
    public GameObject basket;
    public float grabRadius;
    public GameObject infoWindow;
    public SpriteRenderer fullBox;
    public Sprite emptyBox;

    
  
    void Update()
    {
        
        Vector3 position1 = player.transform.position;
        Vector3 position2 = basket.transform.position;
        float distance = Vector3.Distance(position1, position2);

        if (distance < grabRadius  && infoWindow != null)
        {
            
            infoWindow.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.G) && distance < grabRadius)
        {
            Debug.Log("DAJ MNIE TO");
            fullBox.sprite=emptyBox;
            Destroy(infoWindow);
        }

        if (distance > grabRadius && infoWindow != null)
        {
            infoWindow.SetActive(false);
            
            
        }
        Debug.Log(distance);
    }

    void Awake()
    {
       // fullBox = GetComponent<SpriteRenderer>();
        
    }
}
