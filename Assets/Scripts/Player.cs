using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    private Vector2 movement;
    
    void Update()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");
            
        
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.sqrMagnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.MovePosition(rb.position+movement*speed);

        
    }
}
