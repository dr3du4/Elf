using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{   [Header( "Movement parameters" )]
    [Range( 0.01f, 20.0f )] [SerializeField] private float moveSpeed = 0.5f; 
    
    [Space( 10 )]
    
    private Rigidbody2D rigidBody;
    private bool isFacingRight=true;
    private Animator animator;
    private float rayLength = 1.5f;
    private int score = 0;
    public int lives = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate( moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World );
            if (isFacingRight == false)  
            {
                Flip(); 
            }
        }

        
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
            if (isFacingRight == true)
            {
                Flip();
            }
        }
        
        
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0.0f, moveSpeed * Time.deltaTime, 0.0f, Space.World);
        }
        
        
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(0.0f, -moveSpeed * Time.deltaTime, 0.0f, Space.World);
        }

        
        //Debug.DrawRay(transform.position,rayLength*Vector3.down, Color.white,1,false);
        
        
    }
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
        
    }

  
 
}