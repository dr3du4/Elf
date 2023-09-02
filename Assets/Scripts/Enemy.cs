using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Moving")]
    [Range( 0.0f, 20.0f )] [SerializeField] private float moveSpeed = 1.0f; 
    [SerializeField] private float moveRange = 1.0f;
    private float startPositionX;
    private bool isFacingRight=false;
    public bool isMovingRight = true;
    
    private int healthPoints = 40;
    private Animator animator;
    
    [Header("Scripts")]
    public Weapon weapon;
    public Statistic stats;
    public List<Sword> dropList;
    public Move moving;

    public SwordDisplay sword;
    // Update is called once per frame
    void Update()
    {
        isMovingRight=moving.Moving(moveRange, isFacingRight,isMovingRight,startPositionX,moveSpeed);
    }

   
    void Awake()
    {
        startPositionX = this.transform.position.x;
             animator = GetComponent<Animator>();
            
    }

    private IEnumerator KillOnAnimationEnd()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {   
     
       Fight(other);
    }

    void Drop()
    {
        
    }

    void Fight(Collider2D other)
    {
        if (other.CompareTag("Weapon") == true)
        {   
            if (Input.GetKey(KeyCode.Space) == true)
            {  
                //sprawdzic strukture stats
                healthPoints -= sword.damage;
                Debug.Log(healthPoints);
                if (healthPoints <= 0)
                {
                    Destroy(gameObject);
                }

            }

        }

    }
}
