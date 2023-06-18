using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalkingScript : MonoBehaviour
{
    public Dialogue dialog;
    public bool startTalking = false;
    public GameObject player;
    public GameObject trader;
    
    
// Możesz teraz użyć wartości "distance" w swoim kodzie
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TraderTalkingArea") )
        {
            startTalking = true;
        }
       
    }
    //private void OnTriggerExit(Collider2D other)
    //{
    //    if (other.CompareTag("TraderTalkingArea") )
   //     {
    //        startTalking = false;
    //    }
   // }
    void Update()
    {
        
        Vector3 position1 = player.transform.position;
        Vector3 position2 = trader.transform.position;
        float distance = Vector3.Distance(position1, position2);
        

        if (Input.GetKeyDown(KeyCode.E) && startTalking)
        {
            Debug.Log("In area");
            {
                dialog.StartDialogue();
            }
        }

        if (distance > 0.20)
        {
            dialog.StopDialogue();
        }
    }

    void Awake()
    {
        
    }
}
