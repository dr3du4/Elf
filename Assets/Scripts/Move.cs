using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public  bool Moving(float moveRange, bool isFacingRight,bool isMovingRight, float startPositionX, float Speed)
    {
        if (isMovingRight == true)
        {
            if (this.transform.position.x <= startPositionX + moveRange)
            {
                MoveRight(Speed, isFacingRight, isMovingRight);
            }
            else
            {
                isMovingRight = false;
                MoveLeft(Speed, isFacingRight, isMovingRight);
                //isFacingRight=Flip(isFacingRight);
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
                isMovingRight = true;
               MoveRight(Speed, isFacingRight, isMovingRight);
               
            }
        }

        return isMovingRight;
    }
    bool MoveRight(float moveSpeed,bool isFacingRight,bool isMovingRight)
    {
        transform.Translate( moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World );
        isMovingRight = true;
        if (isFacingRight == false)
        {
            isFacingRight = true;
        }
        return isMovingRight;
    }

    bool MoveLeft(float moveSpeed,bool isFacingRight,bool isMovingRight)
    {
        
        transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
        isMovingRight = false;
        if (isFacingRight == true)
        {
            isFacingRight=false;
        }

        return isMovingRight;
    }
    bool Flip(bool isFacingRight)
    {
         
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
        return isFacingRight;
    }
}
