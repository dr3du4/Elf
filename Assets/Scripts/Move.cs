using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public void Moving(float moveRange, bool isFacingRight,bool isMovingRight, float startPositionX, float Speed)
    {
        if (isMovingRight == true)
        {
            if (this.transform.position.x <= startPositionX + moveRange)
            {
                MoveRight(Speed, isFacingRight, isMovingRight);
            }
            else
            {
                MoveLeft(Speed, isFacingRight, isMovingRight);
            }
        }
        else
        {
            if (this.transform.position.x >= startPositionX - moveRange)
            {
                MoveLeft(Speed, isFacingRight, isMovingRight);
            }
            else
            { 
               MoveRight(Speed, isFacingRight, isMovingRight);
               Flip(isFacingRight);
            }
        }
    }
    void MoveRight(float moveSpeed,bool isFacingRight,bool isMovingRight)
    {
        transform.Translate( moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World );
        isMovingRight = true;
        if (isFacingRight == false)  
        {
            Flip(isFacingRight); 
        }
    }

    void MoveLeft(float moveSpeed,bool isFacingRight,bool isMovingRight)
    {
        
        transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
        isMovingRight = false;
        if (isFacingRight == true)
        {
            Flip(isFacingRight);
        }
    }
    private void Flip(bool isFacingRight)
    {
         
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
        
    }
}
