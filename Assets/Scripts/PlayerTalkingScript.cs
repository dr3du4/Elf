using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalkingScript : MonoBehaviour
{
    public Dialogue dialog;
    public bool startTalking = false;
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TraderTalkingArea") )
        {
            startTalking = true;
        }
       
    }
    private void OnTriggerExit(Collider2D other)
    {
        if (other.CompareTag("TraderTalkingArea") )
        {
            startTalking = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && startTalking)
        {
            Debug.Log("In area");
            {
                dialog.StartDialogue();
            }
        }
        else if (startTalking == false)
        {
            dialog.StopAllCoroutines();
        }

        
    }
}
