using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalkingScript : MonoBehaviour
{
    public Dialogue dialog;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TraderTalkingArea") )
        {   Debug.Log("In area");
            if(Input.GetKey(KeyCode.Space))
            {
                dialog.StartDialogue();
            }
        }
    }
}
