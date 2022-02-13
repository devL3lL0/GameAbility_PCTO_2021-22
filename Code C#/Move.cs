using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This scirpt deals with the movement and behavior of the platform
public class Move : MonoBehaviour
{
    public Vector3 movimento;               

    void start()
    {
        movimento.x = 0;            //We initialize the x and y of the platform
        movimento.y = -4;           // x = 0  y = -4
    }
    
    void Update()
    {
        if(Input.GetMouseButton(0) || Input.GetKey(KeyCode.A)){         //we define the commands to manage the movement of the platform
            movimento.y = -4;                                           //to move the platform to the left -------> left mouse button or A key on the keyboard

            if (movimento.x > -6.40f){                        //if the x exceeds the indicated value, the platform is no longer moved to the left to prevent it from leaving the game screen
                movimento.x -= 0.04f;
                transform.position = movimento;
            }
            
        }
        if(Input.GetMouseButton(1) || Input.GetKey(KeyCode.D)){         //to move the platform to the right -------> left mouse button or keyboard D key
            movimento.y = -4;
            
            if(movimento.x < 6.40f){                        //same thing as the previous if but to the right
                movimento.x += 0.04f;
                transform.position = movimento;
            }  
        }
    }
}
