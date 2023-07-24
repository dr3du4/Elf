using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkScript : MonoBehaviour
{
    public Dialogue dialog;
    public bool startTalking = false;
    public GameObject player;
    public GameObject NPC;
    public float talkRadius;
    public GameObject infoWindow;

    
    void Update()
    {
        
        Vector3 position1 = player.transform.position;
        Vector3 position2 = NPC.transform.position;
        float distance = Vector3.Distance(position1, position2);

        if (distance < talkRadius)
        {
            infoWindow.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && startTalking==false)
        {
            Debug.Log("In area");
            Debug.Log(dialog.isClicked);
            startTalking = true;
            if(dialog.isClicked==false)
            {
                dialog.StartDialogue();
                Debug.Log("fsdfdsf");
                
            }
        }

        if (distance > talkRadius)
        {
            startTalking = false;
            infoWindow.SetActive(false);
            dialog.StopDialogue();
        }
      
    }
}
