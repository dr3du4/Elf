using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Boolean isSwing = false;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            Debug.Log("click");
            animator.SetTrigger("swing");
        }
    }
    
    void Awake()
    {
        
        animator = GetComponent<Animator>();
       
    }
}
