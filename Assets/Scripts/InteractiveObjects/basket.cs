using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : Collidable
{
    public GameObject hoverText;
    public SpriteRenderer fullBasket;
    private bool isFull = true;
    public Sprite emptyBasket;
    
    

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if(hoverText)
                hoverText.SetActive(true);
            
            if (Input.GetKey(KeyCode.G)&&isFull)
            {
                fullBasket.sprite = emptyBasket;
                isFull = false;
                
                Destroy(hoverText);
                
            }
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (hoverText)
            {
              hoverText.SetActive(false);  
            }
            
        }
    }
}
