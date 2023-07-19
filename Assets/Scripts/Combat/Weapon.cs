using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public bool isSwing = false;
    private Animator animator;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            
            animator.SetTrigger("swing");
            
            
        }
    }
    
    void Awake()
    {
        
        animator = GetComponent<Animator>();
       
    }
}
