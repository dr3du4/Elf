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
        {   Debug.Log("In area");
            {
                dialog.StartDialogue();
            }
        }
    }
    void Update()
    {
       
    }
}
