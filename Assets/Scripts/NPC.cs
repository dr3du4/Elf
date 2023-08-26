using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collidable
{
    public Dialogue dialog;
    public bool startTalking = true;
    // Start is called before the first frame update
    public GameObject infoWindow;
    
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if(infoWindow)
                
                infoWindow.SetActive(true);

            if (Input.GetKey(KeyCode.E) && startTalking) 
            {
               
                if(dialog.isClicked==false)
                {
                    Debug.Log("innn");
                    dialog.StartDialogue();
                
                }
                
            }
          
        }
      
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
              infoWindow.SetActive(false);
            dialog.StopDialogue();
            
         }
   
    }
}
