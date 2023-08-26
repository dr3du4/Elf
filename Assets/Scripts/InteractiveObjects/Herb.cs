using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Herb : Collidable
{
    public GameObject hoverText;
    public GameObject plant;
    private bool isFull = true;
    
    

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if(hoverText)
                hoverText.SetActive(true);
            
            if (Input.GetKey(KeyCode.G)&&isFull)
            {
                Destroy(plant);
                isFull = false;
                
                Destroy(hoverText);
                
            }
            
        }
      
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            hoverText.SetActive(false);
        }
    }
    
}